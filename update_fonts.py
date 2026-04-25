import os
import re

def update_designer_fonts(root_dir):
    for root, dirs, files in os.walk(root_dir):
        for file in files:
            if file.endswith(".Designer.cs"):
                file_path = os.path.join(root, file)
                with open(file_path, 'r', encoding='utf-8') as f:
                    content = f.read()

                # Pattern 1: new Font("Segoe UI", 12F) -> new Font("Algerian", 12F, FontStyle.Italic)
                # We need to handle cases where there's no FontStyle argument
                new_content = re.sub(r'new Font\("Segoe UI",\s*([0-9.]+)F\)', 
                                     r'new Font("Algerian", \1F, FontStyle.Italic)', content)
                
                # Pattern 2: new Font("Segoe UI", 12F, FontStyle.Bold) -> new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic)
                new_content = re.sub(r'new Font\("Segoe UI",\s*([0-9.]+)F,\s*FontStyle\.([a-zA-Z]+)\)', 
                                     r'new Font("Algerian", \1F, FontStyle.\2 | FontStyle.Italic)', new_content)

                # Also handle cases where FontStyle is already mixed (though rare in designer)
                # new Font("Algerian", 12F, FontStyle.Bold | FontStyle.Italic) - if already Algerian, skip or ensure Italic
                
                # Just in case there are other font families being used
                new_content = new_content.replace('"Segoe UI"', '"Algerian"')
                new_content = new_content.replace('"Microsoft Sans Serif"', '"Algerian"')
                new_content = new_content.replace('"Arial"', '"Algerian"')

                if new_content != content:
                    with open(file_path, 'w', encoding='utf-8') as f:
                        f.write(new_content)
                    print(f"Updated: {file}")

if __name__ == "__main__":
    update_designer_fonts(".")

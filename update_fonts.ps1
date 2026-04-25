$files = Get-ChildItem -Filter *.Designer.cs -Recurse

foreach ($file in $files) {
    $content = Get-Content $file.FullName -Raw
    $changed = $false

    # Pattern 1: new Font("Segoe UI", 12F) -> new Font("Algerian", 12F, [System.Drawing.FontStyle]::Italic)
    # Using [System.Drawing.FontStyle] because the namespace might not be imported or short-hand might fail in some contexts
    # But usually it's just FontStyle.Italic
    
    $newContent = $content -replace 'new Font\("Segoe UI",\s*([0-9.]+)F\)', 'new Font("Algerian", $1F, FontStyle.Italic)'
    $newContent = $newContent -replace 'new Font\("Segoe UI",\s*([0-9.]+)F,\s*FontStyle\.([a-zA-Z]+)\)', 'new Font("Algerian", $1F, FontStyle.$2 | FontStyle.Italic)'
    
    # Other fonts
    $newContent = $newContent -replace '"Segoe UI"', '"Algerian"'
    $newContent = $newContent -replace '"Microsoft Sans Serif"', '"Algerian"'
    
    if ($newContent -ne $content) {
        $newContent | Set-Content $file.FullName
        Write-Host "Updated: $($file.Name)"
    }
}

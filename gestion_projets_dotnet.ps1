# Récupère le dossier contenant le script PowerShell actuel
$cheminDossierLocal = Split-Path -Parent $MyInvocation.MyCommand.Definition

# Liste statique des projets à vérifier
$projets = @("HelloWord", "TP1", "TP2Ex1")  # Liste des projets

# Liste tous les sous-dossiers du dossier local
$projetsDossier = Get-ChildItem -Path $cheminDossierLocal -Recurse -Directory

# Parcours chaque projet de la liste
foreach ($projet in $projets) {
    # Recherche du dossier correspondant au projet dans la liste des sous-dossiers
    $projetDossier = $projetsDossier | Where-Object { $_.Name -eq $projet }

    if ($projetDossier) {
        Write-Host "Projet '$projet' trouvé dans le dossier : $($projetDossier.FullName)"

        # Accède au dossier du projet
        Set-Location -Path $projetDossier.FullName

        # Exécute les commandes dotnet
        try {
            Write-Host "Exécution de 'dotnet clean' pour le projet '$projet'..."
            dotnet clean
            Write-Host "Exécution de 'dotnet restore' pour le projet '$projet'..."
            dotnet restore
            Write-Host "Exécution de 'dotnet build' pour le projet '$projet'..."
            dotnet build
            Write-Host "Toutes les commandes ont été exécutées avec succès pour le projet '$projet'."
        } catch {
            Write-Host "Une erreur est survenue lors de l'exécution des commandes pour le projet '$projet'."
        }
    } else {
        Write-Host "Le projet '$projet' n'a pas été trouvé dans le dossier spécifié."
    }
}

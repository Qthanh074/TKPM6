pipeline {
    agent any

    stages {
        stage('Clone') {
            steps {
                echo 'Cloning source code'
                git branch: 'main', url: 'https://github.com/Qthanh074/TKPM6.git'
            }
        }

        stage('Restore Packages') {
            steps {
                echo 'Restoring NuGet packages'
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                echo 'Building project (.NET Core)'
                bat 'dotnet build --configuration Release'
            }
        }

        stage('Run Tests') {
            steps {
                echo 'Running tests...'
                bat 'dotnet test --no-build --verbosity normal'
            }
        }

        stage('Publish Artifacts') {
            steps {
                echo 'Publishing to local folder'
                bat 'dotnet publish -c Release -o ./publish'
            }
        }

        stage('Copy to IIS Folder') {
            steps {
                echo 'Copying published files to IIS root'
                bat 'xcopy "%WORKSPACE%\\publish" "C:\\inetpub\\wwwroot\\TKPM456" /E /Y /I /R'
            }
        }

        stage('Deploy to IIS') {
            steps {
                powershell '''
                    Import-Module WebAdministration
                    if (-not (Test-Path IIS:\\Sites\\TKPM456)) {
                        New-Website -Name "TKPM456" -Port 84 -PhysicalPath "C:\\inetpub\\wwwroot\\TKPM456"
                    } else {
                        Restart-WebAppPool "TKPM456"
                    }
                '''
            }
        }
    }
}

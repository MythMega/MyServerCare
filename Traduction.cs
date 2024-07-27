using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCServCare
{
    public static class Traduction
    {
        public static string TranslateByCode(string item, string item_dynamic_1 = null, string item_dynamic_2 = null, string item_dynamic_3 = null, string item_dynamic_4 = null)
        {
            string FULL_APP_LANGUAGE = new ServerManager().GetProfileValue("langue");
            string r = "Missing Translation";
            switch (FULL_APP_LANGUAGE)
            {
                case "FR":
                    switch (item)
                    {
                        case "Error.DirNotExist": r = $"Le dossier {item_dynamic_1} n'existe pas."; break;
                        case "Error.DirAlreadyExist": r = $"Le dossier {item_dynamic_1} existe déjà."; break;
                        case "Error.RenameError": r = $"Erreur lors du renommage."; break;
                        case "Erreur.NoWorld": r = $"Erreur aucun monde selectionné"; break;

                        case "Common.Quitter": r = "Fermer"; break;
                        case "Common.Close": r = "Fermer"; break;
                        case "Common.Cancel": r = "Annuler"; break;
                        case "Common.Add": r = "Ajouter"; break;
                        case "Common.Remove": r = "Supprimer"; break;
                        case "Common.Download": r = "Télécharger"; break;
                        case "Common.SelectAll": r = "Tout selectionner"; break;
                        case "Common.UnselectAll": r = "Tout désélectionner"; break;
                        case "Common.Save": r = "Sauvegarder"; break;
                        case "Common.Generate": r = "Générer"; break;
                        case "Common.Import": r = "Importer"; break;
                        case "Common.WorldName": r = "Nom du monde"; break;
                        case "Common.Success": r = "Succés."; break;
                        case "Common.Fail": r = "Échec."; break;
                        case "Common.Refresh": r = "Actualiser"; break;
                        case "Common.DatapackDB": r = "Banque de datapack"; break;
                        case "Common.Validate": r = "Valider"; break;

                        case "DatapackDB.AddDatapack": r = "Ajouter un datapack"; break;
                        case "DatapackDB.DelDatapack": r = "Supprimer un datapack"; break;
                        case "DatapackDB.InvalidDatapack": r = $"L'élément nommé {item_dynamic_1} n'est pas valide"; break;

                        case "JavaFinder.Explanation": r = "A la recherche d'une version java à télécharger ? Selectionnez votre version minecraft cible"; break;

                        case "RemoveJava.SelectExeFile": r = "Sélectionnez un fichier java.exe"; break;
                        case "RemoveJava.ConfirmDeleteJavaVersion": r = $"Do you really want to delete java version ({item_dynamic_1}) from the list ? This is permanent."; break;

                        case "WorldEditor.System": r = "Système"; break;
                        case "WorldEditor.Custom": r = "Base de donnée"; break;
                        case "WorldEditor.GenerateNewDatapack": r = "Générer nouveau datapack"; break;
                        case "WorldEditor.ErrorEmptyName": r = "Erreur : le nom de monde ne peut pas être vide"; break;
                        case "WorldEditor.DatapackGeneratedDesc": r = "Datapack généré avec MCServerCare"; break;
                        case "WorldEditor.DatapackCommentLoad": r = "écrire ici toutes les fonctions ou commandes qui seront éxecutée au chargement du datapack"; break;
                        case "WorldEditor.DatapackCommentTick": r = "écrire ici toutes les fonctions ou commandes qui seront éxecutée à chaque tick (20 fois par seconde)"; break;

                        case "WorldCreator.CreationEditionWorld": r = $"Création/Edition de monde"; break;
                        case "WorldCreator.WorldName": r = $"Nom du monde :"; break;
                        case "WorldCreator.WorldAlreadyExist": r = $"Monde déjà existant ?"; break;
                        case "WorldCreator.VerifyName": r = $"Vérifier nom."; break;
                        case "WorldCreator.GenerationPreset": r = $"Preset de génération :"; break;
                        case "WorldCreator.DatapackList": r = $"Liste de datapack :"; break;
                        case "WorldCreator.DatapackBank": r = $"Banque de datapack :"; break;
                        case "WorldCreator.EditWorld": r = $"Éditer le monde"; break;


                        case "Main.ViewDistance": r = $"Vue (chunk)"; break;
                        case "Main.DownloadServerJar": r = $"Télécharger .jar serveur"; break;
                        case "Main.UpdateServer": r = $"Mettre à jour serveur"; break;
                        case "Main.StartServer": r = $"Démarrer le serveur"; break;
                        case "Main.ChangeRam": r = $"Changer ram allouée"; break;
                        case "Main.WorldCreation": r = $"Créateur de monde"; break;
                        case "Main.SwitchActiveWorld": r = $"Changer monde actif"; break;
                        case "Main.ChangeMOTD": r = $"Changer MOTD"; break;
                        case "Main.G_System": r = $"Système"; break;
                        case "Main.G_Settings": r = $"Paramètres"; break;
                        case "Main.G_Crack": r = $"Premium uniquement"; break;
                        case "Main.G_Maps": r = $"Gestions de mondes"; break;
                        case "Main.G_Range": r = $"Distance"; break;
                        case "Main.TSMI_File": r = $"Fichier"; break;
                        case "Main.TSMI_Info": r = $"Information"; break;
                        case "Main.LANG_Choice": r = $"Langue"; break;
                        case "Main.INFO_Version": r = $"Version"; break;
                        case "Main.INFO_Changelog": r = $"Journaux de changements"; break;
                        case "Main.INFO_Repository": r = $"Repos du projet"; break;
                        case "Main.INFO_Creator": r = $"Créateurs"; break;
                        case "Main.INFO_Contributor": r = $"Contributors"; break;
                        case "Main.INFO_RoadMap": r = $"Road Map"; break;
                        case "Main.JAVA_GetAnotherJava": r = $"Obtenir une autre version Java"; break;
                        case "Main.JAVA_HowToInstallJava": r = $"Installer une autre version Java"; break;
                        case "Main.JAVA_HowToInstallJavaTutorial": r = $"Pour installer une autre version de Java, ouvrez le menu \"Config\" ► \"Java\" ► \"Obtenir une autre version de Java\"\n\nRemplissez ensuite le formulaire pour trouver la bonne version de Java correspondant à la version minecraft ciblée.\n\nTélécharger ensuite le fichier .zip en cliquant sur télécharger.\nDécompressez cette archive (nous vous recommandons de choisir un chemin court)\n\nEnsuite, pour ajouter cette version Java à vos choix de version, vous devrez cliquer sur l'icone '+' à droite du selecteur de version Java\nCela va ouvrir une fênetre de dialogue, vous devrez localiser le fichier java.exe dans l'archive décompressée. Ce fichier se trouve dans <nom de la version> / bin * java.exe.\nVous pouvez aussi faire cette action en selectionnant \"Config\" ► \"Java\" ► \"Gérer les version Java\""; break;
                        case "Main.JAVA_RemoveJavaInSwitcher": r = $"Gérer les version Java actives"; break;
                        case "Main.PLUG_Toggle": r = $"Activer/Désactiver plugins"; break;
                        case "Main.PLUG_List": r = $"Liste de plugins"; break;
                        case "Main.PLUG_OpenFolder": r = $"Ouvrir le dossier de plugins"; break;
                        case "Main.LabelDownloadJar": r = $"Télécharger l'un des serveur parmis les types suivants et renommez 'server.jar'."; break;
                        case "Main.NOTIF_MOTDChanged": r = $"Le MOTD a bien été mis à jour"; break;
                        case "Main.NOTIF_Updated": r = $"modifié - "; break;
                    }
                    break;

                case "EN":
                    switch (item)
                    {
                        case "Error.DirNotExist": r = $"The directory {item_dynamic_1} does not exist."; break;
                        case "Error.DirAlreadyExist": r = $"The directory {item_dynamic_1} already exists."; break;
                        case "Error.RenameError": r = $"Error during renaming."; break;
                        case "Erreur.NoWorld": r = $"Error no world selected"; break;

                        case "Common.Quitter": r = "Close"; break;
                        case "Common.Close": r = "Close"; break;
                        case "Common.Cancel": r = "Cancel"; break;
                        case "Common.Add": r = "Add"; break;
                        case "Common.Remove": r = "Remove"; break;
                        case "Common.Download": r = "Download"; break;
                        case "Common.SelectAll": r = "Select all"; break;
                        case "Common.UnselectAll": r = "Unselect all"; break;
                        case "Common.Save": r = "Save"; break;
                        case "Common.Generate": r = "Generate"; break;
                        case "Common.Import": r = "Import"; break;
                        case "Common.WorldName": r = "World name"; break;
                        case "Common.Success": r = "Success."; break;
                        case "Common.Fail": r = "Failure."; break;
                        case "Common.Refresh": r = "Refresh"; break;
                        case "Common.DatapackDB": r = "Datapack bank"; break;
                        case "Common.Validate": r = "Validate"; break;

                        case "DatapackDB.AddDatapack": r = "Add a datapack"; break;
                        case "DatapackDB.DelDatapack": r = "Remove a datapack"; break;
                        case "DatapackDB.InvalidDatapack": r = $"The item named {item_dynamic_1} is not valid"; break;

                        case "JavaFinder.Explanation": r = "Looking for a java version to download? Select your target minecraft version"; break;

                        case "RemoveJava.SelectExeFile": r = "Select a java.exe file"; break;
                        case "RemoveJava.ConfirmDeleteJavaVersion": r = $"Do you really want to delete java version ({item_dynamic_1}) from the list ? This is permanent."; break;

                        case "WorldEditor.System": r = "System"; break;
                        case "WorldEditor.Custom": r = "Database"; break;
                        case "WorldEditor.GenerateNewDatapack": r = "Generate new datapack"; break;
                        case "WorldEditor.ErrorEmptyName": r = "Error: world name cannot be empty"; break;
                        case "WorldEditor.DatapackGeneratedDesc": r = "Datapack generated with MCServerCare"; break;
                        case "WorldEditor.DatapackCommentLoad": r = "write here all the functions or commands that will be executed when loading the datapack"; break;
                        case "WorldEditor.DatapackCommentTick": r = "write here all the functions or commands that will be executed every tick (20 times per second)"; break;

                        case "WorldCreator.CreationEditionWorld": r = $"Creation/Edition of world"; break;
                        case "WorldCreator.WorldName": r = $"World name:"; break;
                        case "WorldCreator.WorldAlreadyExist": r = $"World already existing?"; break;
                        case "WorldCreator.VerifyName": r = $"Verify name."; break;
                        case "WorldCreator.GenerationPreset": r = $"Generation preset:"; break;
                        case "WorldCreator.DatapackList": r = $"Datapack list:"; break;
                        case "WorldCreator.DatapackBank": r = $"Datapack bank:"; break;
                        case "WorldCreator.EditWorld": r = $"Edit the world"; break;

                        case "Main.ViewDistance": r = $"View (chunk)"; break;
                        case "Main.DownloadServerJar": r = $"Download .jar server"; break;
                        case "Main.UpdateServer": r = $"Update server"; break;
                        case "Main.StartServer": r = $"Start the server"; break;
                        case "Main.ChangeRam": r = $"Change allocated ram"; break;
                        case "Main.WorldCreation": r = $"World creator"; break;
                        case "Main.SwitchActiveWorld": r = $"Change active world"; break;
                        case "Main.ChangeMOTD": r = $"Change MOTD"; break;
                        case "Main.G_System": r = $"System"; break;
                        case "Main.G_Settings": r = $"Settings"; break;
                        case "Main.G_Crack": r = $"Premium only"; break;
                        case "Main.G_Maps": r = $"Worlds management"; break;
                        case "Main.G_Range": r = $"Distance"; break;
                        case "Main.TSMI_File": r = $"File"; break;
                        case "Main.TSMI_Info": r = $"Information"; break;
                        case "Main.LANG_Choice": r = $"Language"; break;
                        case "Main.INFO_Version": r = $"Version"; break;
                        case "Main.INFO_Changelog": r = $"Change logs"; break;
                        case "Main.INFO_Repository": r = $"Project repos"; break;
                        case "Main.INFO_Creator": r = $"Creators"; break;
                        case "Main.INFO_Contributor": r = $"Contributors"; break;
                        case "Main.INFO_RoadMap": r = $"Road Map"; break;
                        case "Main.JAVA_GetAnotherJava": r = $"Get another Java version"; break;
                        case "Main.JAVA_HowToInstallJava": r = $"Install another Java version"; break;
                        case "Main.JAVA_RemoveJavaInSwitcher": r = $"Manage active Java versions"; break;
                        case "Main.JAVA_HowToInstallJavaTutorial": r = $"To install another version of Java, open the \"Config\" menu ► \"Java\" ► \"Get another version of Java\"\n\nThen fill out the form to find the right version of Java corresponding to the targeted Minecraft version.\n\nThen download the .zip file by clicking on download.\nUnzip this archive (we recommend you choose a short path)\n\nThen, to add this Java version to your version choices, you will have to click on the '+' icon to the right of the Java version selector\nThis will open a dialog window, you will have to locate the java.exe file in the unzipped archive. This file is located in <version name> / bin * java.exe.\nYou can also do this action by selecting \"Config\" ► \"Java\" ► \"Manage Java versions\""; break;
                        case "Main.PLUG_Toggle": r = $"Enable/Disable plugins"; break;
                        case "Main.PLUG_List": r = $"Plugins list"; break;
                        case "Main.PLUG_OpenFolder": r = $"Open the plugins folder"; break;
                        case "Main.LabelDownloadJar": r = $"Download one of the servers among the following types and rename to 'server.jar'."; break;
                        case "Main.NOTIF_MOTDChanged": r = $"The MOTD has been updated"; break;
                        case "Main.NOTIF_Updated": r = $"modified - "; break;
                    }
                    break;

                case "ES":
                    switch (item)
                    {
                        case "Error.DirNotExist": r = $"El directorio {item_dynamic_1} no existe."; break;
                        case "Error.DirAlreadyExist": r = $"El directorio {item_dynamic_1} ya existe."; break;
                        case "Error.RenameError": r = $"Error durante el cambio de nombre."; break;
                        case "Erreur.NoWorld": r = $"Error no se seleccionó ningún mundo"; break;

                        case "Common.Quitter": r = "Cerrar"; break;
                        case "Common.Close": r = "Cerrar"; break;
                        case "Common.Cancel": r = "Cancelar"; break;
                        case "Common.Add": r = "Añadir"; break;
                        case "Common.Remove": r = "Eliminar"; break;
                        case "Common.Download": r = "Descargar"; break;
                        case "Common.SelectAll": r = "Seleccionar todo"; break;
                        case "Common.UnselectAll": r = "Deseleccionar todo"; break;
                        case "Common.Save": r = "Guardar"; break;
                        case "Common.Generate": r = "Generar"; break;
                        case "Common.Import": r = "Importar"; break;
                        case "Common.WorldName": r = "Nombre del mundo"; break;
                        case "Common.Success": r = "Éxito."; break;
                        case "Common.Fail": r = "Fracaso."; break;
                        case "Common.Refresh": r = "Actualizar"; break;
                        case "Common.DatapackDB": r = "Banco de Datapack"; break;
                        case "Common.Validate": r = "Validar"; break;

                        case "DatapackDB.AddDatapack": r = "Añadir un datapack"; break;
                        case "DatapackDB.DelDatapack": r = "Eliminar un datapack"; break;
                        case "DatapackDB.InvalidDatapack": r = $"El elemento llamado {item_dynamic_1} no es válido"; break;

                        case "JavaFinder.Explanation": r = "¿Buscando una versión de Java para descargar? Seleccione su versión de Minecraft objetivo"; break;

                        case "RemoveJava.SelectExeFile": r = "Seleccione un archivo java.exe"; break;
                        case "RemoveJava.ConfirmDeleteJavaVersion": r = $"¿Realmente quieres eliminar la versión de Java ({item_dynamic_1}) de la lista? Esto es permanente."; break;

                        case "WorldEditor.System": r = "Sistema"; break;
                        case "WorldEditor.Custom": r = "Base de datos"; break;
                        case "WorldEditor.GenerateNewDatapack": r = "Generar nuevo datapack"; break;
                        case "WorldEditor.ErrorEmptyName": r = "Error: el nombre del mundo no puede estar vacío"; break;
                        case "WorldEditor.DatapackGeneratedDesc": r = "Datapack generado con MCServerCare"; break;
                        case "WorldEditor.DatapackCommentLoad": r = "escribe aquí todas las funciones o comandos que se ejecutarán al cargar el datapack"; break;
                        case "WorldEditor.DatapackCommentTick": r = "escribe aquí todas las funciones o comandos que se ejecutarán en cada tick (20 veces por segundo)"; break;

                        case "WorldCreator.CreationEditionWorld": r = $"Creación/Edición de mundo"; break;
                        case "WorldCreator.WorldName": r = $"Nombre del mundo:"; break;
                        case "WorldCreator.WorldAlreadyExist": r = $"¿Mundo ya existente?"; break;
                        case "WorldCreator.VerifyName": r = $"Verificar nombre."; break;
                        case "WorldCreator.GenerationPreset": r = $"Preset de generación:"; break;
                        case "WorldCreator.DatapackList": r = $"Lista de datapack:"; break;
                        case "WorldCreator.DatapackBank": r = $"Banco de datapack:"; break;
                        case "WorldCreator.EditWorld": r = $"Editar el mundo"; break;

                        case "Main.ViewDistance": r = $"Vista (chunk)"; break;
                        case "Main.DownloadServerJar": r = $"Descargar .jar del servidor"; break;
                        case "Main.UpdateServer": r = $"Actualizar servidor"; break;
                        case "Main.StartServer": r = $"Iniciar el servidor"; break;
                        case "Main.ChangeRam": r = $"Cambiar RAM asignada"; break;
                        case "Main.WorldCreation": r = $"Creador de mundos"; break;
                        case "Main.SwitchActiveWorld": r = $"Cambiar mundo activo"; break;
                        case "Main.ChangeMOTD": r = $"Cambiar MOTD"; break;
                        case "Main.G_System": r = $"Sistema"; break;
                        case "Main.G_Settings": r = $"Configuraciones"; break;
                        case "Main.G_Crack": r = $"Solo premium"; break;
                        case "Main.G_Maps": r = $"Gestión de mundos"; break;
                        case "Main.G_Range": r = $"Distancia"; break;
                        case "Main.TSMI_File": r = $"Archivo"; break;
                        case "Main.TSMI_Info": r = $"Información"; break;
                        case "Main.LANG_Choice": r = $"Idioma"; break;
                        case "Main.INFO_Version": r = $"Versión"; break;
                        case "Main.INFO_Changelog": r = $"Registros de cambios"; break;
                        case "Main.INFO_Repository": r = $"Repos del proyecto"; break;
                        case "Main.INFO_Creator": r = $"Creadores"; break;
                        case "Main.INFO_Contributor": r = $"Contribuidores"; break;
                        case "Main.INFO_RoadMap": r = $"Mapa de ruta"; break;
                        case "Main.JAVA_GetAnotherJava": r = $"Obtener otra versión de Java"; break;
                        case "Main.JAVA_HowToInstallJava": r = $"Instalar otra versión de Java"; break;
                        case "Main.JAVA_RemoveJavaInSwitcher": r = $"Gestionar versiones de Java activas"; break;
                        case "Main.JAVA_HowToInstallJavaTutorial": r = $"Per installare un'altra versione di Java, apri il menu \"Config\" ► \"Java\" ► \"Ottieni un'altra versione di Java\"\n\nCompila quindi il modulo per trovare la versione corretta di Java corrispondente alla versione di Minecraft di destinazione.\n\nScarica quindi il file .zip cliccando su download.\nDecomprimi questo archivio (ti consigliamo di scegliere un percorso breve)\n\nQuindi, per aggiungere questa versione di Java alle tue scelte di versione, dovrai fare clic sull'icona '+' a destra del selettore di versione di Java\nQuesto aprirà una finestra di dialogo, dovrai localizzare il file java.exe nell'archivio decompresso. Questo file si trova in <nome della versione> / bin * java.exe.\nPuoi anche fare questa azione selezionando \"Config\" ► \"Java\" ► \"Gestisci versioni Java\""; break;
                        case "Main.PLUG_Toggle": r = $"Activar/Desactivar plugins"; break;
                        case "Main.PLUG_List": r = $"Lista de plugins"; break;
                        case "Main.PLUG_OpenFolder": r = $"Abrir la carpeta de plugins"; break;
                        case "Main.LabelDownloadJar": r = $"Descargue uno de los servidores entre los siguientes tipos y cambie el nombre a 'server.jar'."; break;
                        case "Main.NOTIF_MOTDChanged": r = $"El MOTD ha sido actualizado"; break;
                        case "Main.NOTIF_Updated": r = $"modificado - "; break;
                    }
                    break;

                case "DE":
                    switch (item)
                    {
                        case "Error.DirNotExist": r = $"Das Verzeichnis {item_dynamic_1} existiert nicht."; break;
                        case "Error.DirAlreadyExist": r = $"Das Verzeichnis {item_dynamic_1} existiert bereits."; break;
                        case "Error.RenameError": r = $"Fehler beim Umbenennen."; break;
                        case "Erreur.NoWorld": r = $"Fehler keine Welt ausgewählt"; break;

                        case "Common.Quitter": r = "Schließen"; break;
                        case "Common.Close": r = "Schließen"; break;
                        case "Common.Cancel": r = "Abbrechen"; break;
                        case "Common.Add": r = "Hinzufügen"; break;
                        case "Common.Remove": r = "Entfernen"; break;
                        case "Common.Download": r = "Herunterladen"; break;
                        case "Common.SelectAll": r = "Alles auswählen"; break;
                        case "Common.UnselectAll": r = "Auswahl aufheben"; break;
                        case "Common.Save": r = "Speichern"; break;
                        case "Common.Generate": r = "Erzeugen"; break;
                        case "Common.Import": r = "Importieren"; break;
                        case "Common.WorldName": r = "Weltname"; break;
                        case "Common.Success": r = "Erfolg."; break;
                        case "Common.Fail": r = "Fehler."; break;
                        case "Common.Refresh": r = "Aktualisieren"; break;
                        case "Common.DatapackDB": r = "Datapack Bank"; break;
                        case "Common.Validate": r = "Validieren"; break;

                        case "DatapackDB.AddDatapack": r = "Ein Datapack hinzufügen"; break;
                        case "DatapackDB.DelDatapack": r = "Ein Datapack entfernen"; break;
                        case "DatapackDB.InvalidDatapack": r = $"Das Element namens {item_dynamic_1} ist nicht gültig"; break;

                        case "JavaFinder.Explanation": r = "Auf der Suche nach einer Java-Version zum Herunterladen? Wählen Sie Ihre Ziel-Minecraft-Version"; break;

                        case "RemoveJava.SelectExeFile": r = "Wählen Sie eine java.exe-Datei"; break;
                        case "RemoveJava.ConfirmDeleteJavaVersion": r = $"Möchten Sie die Java-Version ({item_dynamic_1}) wirklich aus der Liste löschen? Dies ist dauerhaft."; break;

                        case "WorldEditor.System": r = "System"; break;
                        case "WorldEditor.Custom": r = "Datenbank"; break;
                        case "WorldEditor.GenerateNewDatapack": r = "Neues Datapack generieren"; break;
                        case "WorldEditor.ErrorEmptyName": r = "Fehler: Der Weltname darf nicht leer sein"; break;
                        case "WorldEditor.DatapackGeneratedDesc": r = "Datapack generiert mit MCServerCare"; break;
                        case "WorldEditor.DatapackCommentLoad": r = "Schreiben Sie hier alle Funktionen oder Befehle, die beim Laden des Datapacks ausgeführt werden"; break;
                        case "WorldEditor.DatapackCommentTick": r = "Schreiben Sie hier alle Funktionen oder Befehle, die bei jedem Tick (20 Mal pro Sekunde) ausgeführt werden"; break;

                        case "WorldCreator.CreationEditionWorld": r = $"Erstellung/Bearbeitung von Welt"; break;
                        case "WorldCreator.WorldName": r = $"Weltname:"; break;
                        case "WorldCreator.WorldAlreadyExist": r = $"Welt bereits vorhanden?"; break;
                        case "WorldCreator.VerifyName": r = $"Namen überprüfen."; break;
                        case "WorldCreator.GenerationPreset": r = $"Generierungsvoreinstellung:"; break;
                        case "WorldCreator.DatapackList": r = $"Datapack-Liste:"; break;
                        case "WorldCreator.DatapackBank": r = $"Datapack-Bank:"; break;
                        case "WorldCreator.EditWorld": r = $"Die Welt bearbeiten"; break;

                        case "Main.ViewDistance": r = $"Ansicht (Chunk)"; break;
                        case "Main.DownloadServerJar": r = $"Server .jar herunterladen"; break;
                        case "Main.UpdateServer": r = $"Server aktualisieren"; break;
                        case "Main.StartServer": r = $"Den Server starten"; break;
                        case "Main.ChangeRam": r = $"Zugewiesenen RAM ändern"; break;
                        case "Main.WorldCreation": r = $"Weltenschöpfer"; break;
                        case "Main.SwitchActiveWorld": r = $"Aktive Welt wechseln"; break;
                        case "Main.ChangeMOTD": r = $"MOTD ändern"; break;
                        case "Main.G_System": r = $"System"; break;
                        case "Main.G_Settings": r = $"Einstellungen"; break;
                        case "Main.G_Crack": r = $"Nur Premium"; break;
                        case "Main.G_Maps": r = $"Weltverwaltung"; break;
                        case "Main.G_Range": r = $"Entfernung"; break;
                        case "Main.TSMI_File": r = $"Datei"; break;
                        case "Main.TSMI_Info": r = $"Information"; break;
                        case "Main.LANG_Choice": r = $"Sprache"; break;
                        case "Main.INFO_Version": r = $"Version"; break;
                        case "Main.INFO_Changelog": r = $"Änderungsprotokolle"; break;
                        case "Main.INFO_Repository": r = $"Projekt-Repos"; break;
                        case "Main.INFO_Creator": r = $"Schöpfer"; break;
                        case "Main.INFO_Contributor": r = $"Mitwirkende"; break;
                        case "Main.INFO_RoadMap": r = $"Road Map"; break;
                        case "Main.JAVA_GetAnotherJava": r = $"Eine andere Java-Version bekommen"; break;
                        case "Main.JAVA_HowToInstallJava": r = $"Eine andere Java-Version installieren"; break;
                        case "Main.JAVA_RemoveJavaInSwitcher": r = $"Aktive Java-Versionen verwalten"; break;
                        case "Main.JAVA_HowToInstallJavaTutorial": r = $"Um eine andere Version von Java zu installieren, öffnen Sie das Menü \"Config\" ► \"Java\" ► \"Holen Sie sich eine andere Version von Java\"\n\nFüllen Sie dann das Formular aus, um die richtige Version von Java zu finden, die der Zielversion von Minecraft entspricht.\n\nLaden Sie dann die .zip-Datei herunter, indem Sie auf Download klicken.\nEntpacken Sie dieses Archiv (wir empfehlen Ihnen, einen kurzen Pfad zu wählen)\n\nUm diese Java-Version zu Ihren Versionsoptionen hinzuzufügen, müssen Sie auf das '+'-Symbol rechts vom Java-Versionenauswähler klicken\nDies öffnet ein Dialogfenster, Sie müssen die Datei java.exe im entpackten Archiv lokalisieren. Diese Datei befindet sich in <Versionsname> / bin * java.exe.\nSie können diese Aktion auch durch Auswahl von \"Config\" ► \"Java\" ► \"Java-Versionen verwalten\" durchführen"; break;
                        case "Main.PLUG_Toggle": r = $"Plugins aktivieren/deaktivieren"; break;
                        case "Main.PLUG_List": r = $"Plugin-Liste"; break;
                        case "Main.PLUG_OpenFolder": r = $"Den Plugin-Ordner öffnen"; break;
                        case "Main.LabelDownloadJar": r = $"Laden Sie einen der Server aus den folgenden Typen herunter und benennen Sie ihn in 'server.jar' um."; break;
                        case "Main.NOTIF_MOTDChanged": r = $"Das MOTD wurde aktualisiert"; break;
                        case "Main.NOTIF_Updated": r = $"geändert - "; break;
                    }
                    break;

                case "IT":
                    switch (item)
                    {
                        case "Error.DirNotExist": r = $"La directory {item_dynamic_1} non esiste."; break;
                        case "Error.DirAlreadyExist": r = $"La directory {item_dynamic_1} esiste già."; break;
                        case "Error.RenameError": r = $"Errore durante la rinomina."; break;
                        case "Erreur.NoWorld": r = $"Errore nessun mondo selezionato"; break;

                        case "Common.Quitter": r = "Chiudi"; break;
                        case "Common.Close": r = "Chiudi"; break;
                        case "Common.Cancel": r = "Annulla"; break;
                        case "Common.Add": r = "Aggiungi"; break;
                        case "Common.Remove": r = "Rimuovi"; break;
                        case "Common.Download": r = "Scarica"; break;
                        case "Common.SelectAll": r = "Seleziona tutto"; break;
                        case "Common.UnselectAll": r = "Deseleziona tutto"; break;
                        case "Common.Save": r = "Salva"; break;
                        case "Common.Generate": r = "Genera"; break;
                        case "Common.Import": r = "Importa"; break;
                        case "Common.WorldName": r = "Nome del mondo"; break;
                        case "Common.Success": r = "Successo."; break;
                        case "Common.Fail": r = "Fallimento."; break;
                        case "Common.Refresh": r = "Aggiorna"; break;
                        case "Common.DatapackDB": r = "Banca di Datapack"; break;
                        case "Common.Validate": r = "Convalida"; break;

                        case "DatapackDB.AddDatapack": r = "Aggiungi un datapack"; break;
                        case "DatapackDB.DelDatapack": r = "Rimuovi un datapack"; break;
                        case "DatapackDB.InvalidDatapack": r = $"L'elemento chiamato {item_dynamic_1} non è valido"; break;

                        case "JavaFinder.Explanation": r = "Alla ricerca di una versione di Java da scaricare? Seleziona la tua versione di Minecraft target"; break;

                        case "RemoveJava.SelectExeFile": r = "Seleziona un file java.exe"; break;
                        case "RemoveJava.ConfirmDeleteJavaVersion": r = $"Vuoi davvero eliminare la versione di Java ({item_dynamic_1}) dalla lista? Questo è permanente."; break;

                        case "WorldEditor.System": r = "Sistema"; break;
                        case "WorldEditor.Custom": r = "Database"; break;
                        case "WorldEditor.GenerateNewDatapack": r = "Genera nuovo datapack"; break;
                        case "WorldEditor.ErrorEmptyName": r = "Errore: il nome del mondo non può essere vuoto"; break;
                        case "WorldEditor.DatapackGeneratedDesc": r = "Datapack generato con MCServerCare"; break;
                        case "WorldEditor.DatapackCommentLoad": r = "scrivi qui tutte le funzioni o i comandi che verranno eseguiti al caricamento del datapack"; break;
                        case "WorldEditor.DatapackCommentTick": r = "scrivi qui tutte le funzioni o i comandi che verranno eseguiti ad ogni tick (20 volte al secondo)"; break;

                        case "WorldCreator.CreationEditionWorld": r = $"Creazione/Modifica del mondo"; break;
                        case "WorldCreator.WorldName": r = $"Nome del mondo:"; break;
                        case "WorldCreator.WorldAlreadyExist": r = $"Mondo già esistente?"; break;
                        case "WorldCreator.VerifyName": r = $"Verifica nome."; break;
                        case "WorldCreator.GenerationPreset": r = $"Preset di generazione:"; break;
                        case "WorldCreator.DatapackList": r = $"Lista di datapack:"; break;
                        case "WorldCreator.DatapackBank": r = $"Banca di datapack:"; break;
                        case "WorldCreator.EditWorld": r = $"Modifica il mondo"; break;

                        case "Main.ViewDistance": r = $"Vista (chunk)"; break;
                        case "Main.DownloadServerJar": r = $"Scarica .jar del server"; break;
                        case "Main.UpdateServer": r = $"Aggiorna server"; break;
                        case "Main.StartServer": r = $"Avvia il server"; break;
                        case "Main.ChangeRam": r = $"Cambia RAM assegnata"; break;
                        case "Main.WorldCreation": r = $"Creatore di mondi"; break;
                        case "Main.SwitchActiveWorld": r = $"Cambia mondo attivo"; break;
                        case "Main.ChangeMOTD": r = $"Cambia MOTD"; break;
                        case "Main.G_System": r = $"Sistema"; break;
                        case "Main.G_Settings": r = $"Impostazioni"; break;
                        case "Main.G_Crack": r = $"Solo premium"; break;
                        case "Main.G_Maps": r = $"Gestione dei mondi"; break;
                        case "Main.G_Range": r = $"Distanza"; break;
                        case "Main.TSMI_File": r = $"File"; break;
                        case "Main.TSMI_Info": r = $"Informazione"; break;
                        case "Main.LANG_Choice": r = $"Lingua"; break;
                        case "Main.INFO_Version": r = $"Versione"; break;
                        case "Main.INFO_Changelog": r = $"Registro delle modifiche"; break;
                        case "Main.INFO_Repository": r = $"Repos del progetto"; break;
                        case "Main.INFO_Creator": r = $"Creatori"; break;
                        case "Main.INFO_Contributor": r = $"Contributori"; break;
                        case "Main.INFO_RoadMap": r = $"Road Map"; break;
                        case "Main.JAVA_GetAnotherJava": r = $"Ottieni un'altra versione di Java"; break;
                        case "Main.JAVA_HowToInstallJava": r = $"Installa un'altra versione di Java"; break;
                        case "Main.JAVA_RemoveJavaInSwitcher": r = $"Gestisci versioni di Java attive"; break;
                        case "Main.JAVA_HowToInstallJavaTutorial": r = $"Per installare un'altra versione di Java, apri il menu \"Config\" ► \"Java\" ► \"Ottieni un'altra versione di Java\"\n\nCompila quindi il modulo per trovare la versione corretta di Java corrispondente alla versione di Minecraft di destinazione.\n\nScarica quindi il file .zip cliccando su download.\nDecomprimi questo archivio (ti consigliamo di scegliere un percorso breve)\n\nQuindi, per aggiungere questa versione di Java alle tue scelte di versione, dovrai fare clic sull'icona '+' a destra del selettore di versione di Java\nQuesto aprirà una finestra di dialogo, dovrai localizzare il file java.exe nell'archivio decompresso. Questo file si trova in <nome della versione> / bin * java.exe.\nPuoi anche fare questa azione selezionando \"Config\" ► \"Java\" ► \"Gestisci versioni Java\""; break;
                        case "Main.PLUG_Toggle": r = $"Attiva/Disattiva plugins"; break;
                        case "Main.PLUG_List": r = $"Lista dei plugins"; break;
                        case "Main.PLUG_OpenFolder": r = $"Apri la cartella dei plugins"; break;
                        case "Main.LabelDownloadJar": r = $"Scarica uno dei server tra i seguenti tipi e rinomina in 'server.jar'."; break;
                        case "Main.NOTIF_MOTDChanged": r = $"Il MOTD è stato aggiornato"; break;
                        case "Main.NOTIF_Updated": r = $"modificato - "; break;
                    }
                    break;

                case "PT":
                    switch (item)
                    {
                        case "Error.DirNotExist": r = $"O diretório {item_dynamic_1} não existe."; break;
                        case "Error.DirAlreadyExist": r = $"O diretório {item_dynamic_1} já existe."; break;
                        case "Error.RenameError": r = $"Erro ao renomear."; break;
                        case "Erreur.NoWorld": r = $"Erro nenhum mundo selecionado"; break;

                        case "Common.Quitter": r = "Fechar"; break;
                        case "Common.Close": r = "Fechar"; break;
                        case "Common.Cancel": r = "Cancelar"; break;
                        case "Common.Add": r = "Adicionar"; break;
                        case "Common.Remove": r = "Remover"; break;
                        case "Common.Download": r = "Baixar"; break;
                        case "Common.SelectAll": r = "Selecionar tudo"; break;
                        case "Common.UnselectAll": r = "Desmarcar tudo"; break;
                        case "Common.Save": r = "Salvar"; break;
                        case "Common.Generate": r = "Gerar"; break;
                        case "Common.Import": r = "Importar"; break;
                        case "Common.WorldName": r = "Nome do mundo"; break;
                        case "Common.Success": r = "Sucesso."; break;
                        case "Common.Fail": r = "Falha."; break;
                        case "Common.Refresh": r = "Atualizar"; break;
                        case "Common.DatapackDB": r = "Banco de Datapack"; break;
                        case "Common.Validate": r = "Validar"; break;

                        case "DatapackDB.AddDatapack": r = "Adicionar um datapack"; break;
                        case "DatapackDB.DelDatapack": r = "Remover um datapack"; break;
                        case "DatapackDB.InvalidDatapack": r = $"O item chamado {item_dynamic_1} não é válido"; break;

                        case "JavaFinder.Explanation": r = "Procurando uma versão do Java para baixar? Selecione a sua versão do Minecraft alvo"; break;

                        case "RemoveJava.SelectExeFile": r = "Selecione um arquivo java.exe"; break;
                        case "RemoveJava.ConfirmDeleteJavaVersion": r = $"Você realmente deseja excluir a versão do Java ({item_dynamic_1}) da lista? Isso é permanente."; break;

                        case "WorldEditor.System": r = "Sistema"; break;
                        case "WorldEditor.Custom": r = "Banco de dados"; break;
                        case "WorldEditor.GenerateNewDatapack": r = "Gerar novo datapack"; break;
                        case "WorldEditor.ErrorEmptyName": r = "Erro: o nome do mundo não pode estar vazio"; break;
                        case "WorldEditor.DatapackGeneratedDesc": r = "Datapack gerado com MCServerCare"; break;
                        case "WorldEditor.DatapackCommentLoad": r = "escreva aqui todas as funções ou comandos que serão executados ao carregar o datapack"; break;
                        case "WorldEditor.DatapackCommentTick": r = "escreva aqui todas as funções ou comandos que serão executados a cada tick (20 vezes por segundo)"; break;

                        case "WorldCreator.CreationEditionWorld": r = $"Criação/Edição de mundo"; break;
                        case "WorldCreator.WorldName": r = $"Nome do mundo:"; break;
                        case "WorldCreator.WorldAlreadyExist": r = $"Mundo já existente?"; break;
                        case "WorldCreator.VerifyName": r = $"Verificar nome."; break;
                        case "WorldCreator.GenerationPreset": r = $"Preset de geração:"; break;
                        case "WorldCreator.DatapackList": r = $"Lista de datapack:"; break;
                        case "WorldCreator.DatapackBank": r = $"Banco de datapack:"; break;
                        case "WorldCreator.EditWorld": r = $"Editar o mundo"; break;

                        case "Main.ViewDistance": r = $"Vista (chunk)"; break;
                        case "Main.DownloadServerJar": r = $"Baixar .jar do servidor"; break;
                        case "Main.UpdateServer": r = $"Atualizar servidor"; break;
                        case "Main.StartServer": r = $"Iniciar o servidor"; break;
                        case "Main.ChangeRam": r = $"Alterar RAM alocada"; break;
                        case "Main.WorldCreation": r = $"Criador de mundos"; break;
                        case "Main.SwitchActiveWorld": r = $"Mudar mundo ativo"; break;
                        case "Main.ChangeMOTD": r = $"Alterar MOTD"; break;
                        case "Main.G_System": r = $"Sistema"; break;
                        case "Main.G_Settings": r = $"Configurações"; break;
                        case "Main.G_Crack": r = $"Apenas premium"; break;
                        case "Main.G_Maps": r = $"Gerenciamento de mundos"; break;
                        case "Main.G_Range": r = $"Distância"; break;
                        case "Main.TSMI_File": r = $"Arquivo"; break;
                        case "Main.TSMI_Info": r = $"Informação"; break;
                        case "Main.LANG_Choice": r = $"Idioma"; break;
                        case "Main.LANG_Fr": r = $"Francês"; break;
                        case "Main.LANG_En": r = $"Inglês"; break;
                        case "Main.LANG_De": r = $"Alemão"; break;
                        case "Main.LANG_Es": r = $"Espanhol"; break;
                        case "Main.INFO_Version": r = $"Versão"; break;
                        case "Main.INFO_Changelog": r = $"Registro de alterações"; break;
                        case "Main.INFO_Repository": r = $"Repos do projeto"; break;
                        case "Main.INFO_Creator": r = $"Criadores"; break;
                        case "Main.INFO_Contributor": r = $"Contribuidores"; break;
                        case "Main.INFO_RoadMap": r = $"Mapa de rota"; break;
                        case "Main.JAVA_GetAnotherJava": r = $"Obter outra versão do Java"; break;
                        case "Main.JAVA_HowToInstallJava": r = $"Instalar outra versão do Java"; break;
                        case "Main.JAVA_RemoveJavaInSwitcher": r = $"Gerenciar versões ativas do Java"; break;
                        case "Main.JAVA_HowToInstallJavaTutorial": r = $"Para instalar outra versão do Java, abra o menu \"Config\" ► \"Java\" ► \"Obter outra versão do Java\"\n\nPreencha o formulário para encontrar a versão correta do Java correspondente à versão do Minecraft alvo.\n\nEm seguida, baixe o arquivo .zip clicando em download.\nDescompacte este arquivo (recomendamos que você escolha um caminho curto)\n\nEntão, para adicionar esta versão do Java às suas escolhas de versão, você terá que clicar no ícone '+' à direita do seletor de versão do Java\nIsso abrirá uma janela de diálogo, você terá que localizar o arquivo java.exe no arquivo descompactado. Este arquivo está localizado em <nome da versão> / bin * java.exe.\nVocê também pode fazer esta ação selecionando \"Config\" ► \"Java\" ► \"Gerenciar versões do Java\""; break;
                        case "Main.PLUG_Toggle": r = $"Ativar/Desativar plugins"; break;
                        case "Main.PLUG_List": r = $"Lista de plugins"; break;
                        case "Main.PLUG_OpenFolder": r = $"Abrir a pasta de plugins"; break;
                        case "Main.LabelDownloadJar": r = $"Baixe um dos servidores entre os seguintes tipos e renomeie para 'server.jar'."; break;
                        case "Main.NOTIF_MOTDChanged": r = $"O MOTD foi atualizado"; break;
                        case "Main.NOTIF_Updated": r = $"modificado - "; break;
                    }
                    break;

                case "SE":
                    switch (item)
                    {
                        case "Error.DirNotExist": r = $"Mappen {item_dynamic_1} finns inte."; break;
                        case "Error.DirAlreadyExist": r = $"Mappen {item_dynamic_1} finns redan."; break;
                        case "Error.RenameError": r = $"Fel vid namnbyte."; break;
                        case "Erreur.NoWorld": r = $"Fel ingen värld vald"; break;

                        case "Common.Quitter": r = "Stänga"; break;
                        case "Common.Close": r = "Stänga"; break;
                        case "Common.Cancel": r = "Avbryta"; break;
                        case "Common.Add": r = "Lägga till"; break;
                        case "Common.Remove": r = "Ta bort"; break;
                        case "Common.Download": r = "Ladda ner"; break;
                        case "Common.SelectAll": r = "Välj alla"; break;
                        case "Common.UnselectAll": r = "Avmarkera alla"; break;
                        case "Common.Save": r = "Spara"; break;
                        case "Common.Generate": r = "Generera"; break;
                        case "Common.Import": r = "Importera"; break;
                        case "Common.WorldName": r = "Världens namn"; break;
                        case "Common.Success": r = "Framgång."; break;
                        case "Common.Fail": r = "Misslyckades."; break;
                        case "Common.Refresh": r = "Uppdatera"; break;
                        case "Common.DatapackDB": r = "Datapack-databas"; break;
                        case "Common.Validate": r = "Validera"; break;

                        case "DatapackDB.AddDatapack": r = "Lägg till ett datapack"; break;
                        case "DatapackDB.DelDatapack": r = "Ta bort ett datapack"; break;
                        case "DatapackDB.InvalidDatapack": r = $"Elementet med namnet {item_dynamic_1} är inte giltigt"; break;

                        case "JavaFinder.Explanation": r = "Letar du efter en java-version att ladda ner? Välj din mål-minecraft-version"; break;

                        case "RemoveJava.SelectExeFile": r = "Välj en java.exe-fil"; break;
                        case "RemoveJava.ConfirmDeleteJavaVersion": r = $"Vill du verkligen ta bort java-versionen ({item_dynamic_1}) från listan? Detta är permanent."; break;

                        case "WorldEditor.System": r = "System"; break;
                        case "WorldEditor.Custom": r = "Databas"; break;
                        case "WorldEditor.GenerateNewDatapack": r = "Generera ny datapack"; break;
                        case "WorldEditor.ErrorEmptyName": r = "Fel: världsnamnet kan inte vara tomt"; break;
                        case "WorldEditor.DatapackGeneratedDesc": r = "Datapack genererad med MCServerCare"; break;
                        case "WorldEditor.DatapackCommentLoad": r = "skriv här alla funktioner eller kommandon som kommer att köras vid datapack-laddning"; break;
                        case "WorldEditor.DatapackCommentTick": r = "skriv här alla funktioner eller kommandon som kommer att köras varje tick (20 gånger per sekund)"; break;

                        case "WorldCreator.CreationEditionWorld": r = $"Skapa/Redigera värld"; break;
                        case "WorldCreator.WorldName": r = $"Världens namn:"; break;
                        case "WorldCreator.WorldAlreadyExist": r = $"Världen finns redan?"; break;
                        case "WorldCreator.VerifyName": r = $"Verifiera namn."; break;
                        case "WorldCreator.GenerationPreset": r = $"Generationspreset:"; break;
                        case "WorldCreator.DatapackList": r = $"Datapack-lista:"; break;
                        case "WorldCreator.DatapackBank": r = $"Datapack-bank:"; break;
                        case "WorldCreator.EditWorld": r = $"Redigera världen"; break;


                        case "Main.ViewDistance": r = $"Vy (chunk)"; break;
                        case "Main.DownloadServerJar": r = $"Ladda ner .jar-server"; break;
                        case "Main.UpdateServer": r = $"Uppdatera server"; break;
                        case "Main.StartServer": r = $"Starta servern"; break;
                        case "Main.ChangeRam": r = $"Ändra tilldelad ram"; break;
                        case "Main.WorldCreation": r = $"Världsskapare"; break;
                        case "Main.SwitchActiveWorld": r = $"Byt aktiv värld"; break;
                        case "Main.ChangeMOTD": r = $"Ändra MOTD"; break;
                        case "Main.G_System": r = $"System"; break;
                        case "Main.G_Settings": r = $"Inställningar"; break;
                        case "Main.G_Crack": r = $"Endast premium"; break;
                        case "Main.G_Maps": r = $"Hantering av världar"; break;
                        case "Main.G_Range": r = $"Avstånd"; break;
                        case "Main.TSMI_File": r = $"Fil"; break;
                        case "Main.TSMI_Info": r = $"Information"; break;
                        case "Main.LANG_Choice": r = $"Språk"; break;
                        case "Main.INFO_Version": r = $"Version"; break;
                        case "Main.INFO_Changelog": r = $"Ändringslogg"; break;
                        case "Main.INFO_Repository": r = $"Projektets repos"; break;
                        case "Main.INFO_Creator": r = $"Skapare"; break;
                        case "Main.INFO_Contributor": r = $"Bidragsgivare"; break;
                        case "Main.INFO_RoadMap": r = $"Road Map"; break;
                        case "Main.JAVA_GetAnotherJava": r = $"Få en annan Java-version"; break;
                        case "Main.JAVA_HowToInstallJava": r = $"Installera en annan Java-version"; break;
                        case "Main.JAVA_RemoveJavaInSwitcher": r = $"Hantera aktiva Java-versioner"; break;
                        case "Main.JAVA_HowToInstallJavaTutorial": r = $"För att installera en annan version av Java, öppna menyn \"Config\" ► \"Java\" ► \"Hämta en annan version av Java\"\n\nFyll sedan i formuläret för att hitta rätt version av Java som motsvarar den riktade Minecraft-versionen.\n\nLadda sedan ner .zip-filen genom att klicka på ladda ner.\nPacka upp detta arkiv (vi rekommenderar att du väljer en kort väg)\n\nSedan, för att lägga till denna Java-version till dina versionsval, måste du klicka på '+'-ikonen till höger om Java-versionväljaren\nDetta kommer att öppna ett dialogfönster, du måste hitta java.exe-filen i det uppackade arkivet. Denna fil finns i <versionnamn> / bin * java.exe.\nDu kan också göra detta genom att välja \"Config\" ► \"Java\" ► \"Hantera Java-versioner\""; break;
                        case "Main.PLUG_Toggle": r = $"Aktivera/Inaktivera plugins"; break;
                        case "Main.PLUG_List": r = $"Plugin-lista"; break;
                        case "Main.PLUG_OpenFolder": r = $"Öppna plugin-mappen"; break;
                        case "Main.LabelDownloadJar": r = $"Ladda ner en av serverna bland följande typer och byt namn till 'server.jar'."; break;
                        case "Main.NOTIF_MOTDChanged": r = $"MOTD har uppdaterats korrekt"; break;
                        case "Main.NOTIF_Updated": r = $"ändrad - "; break;
                    }
                    break;

                case "PH":
                    switch (item)
                    {
                        case "Error.DirNotExist": r = $"Ang direktoryo {item_dynamic_1} ay hindi umiiral."; break;
                        case "Error.DirAlreadyExist": r = $"Ang direktoryo {item_dynamic_1} ay umiiral na."; break;
                        case "Error.RenameError": r = $"Error sa pagpapalit ng pangalan."; break;
                        case "Erreur.NoWorld": r = $"Error walang napiling mundo"; break;

                        case "Common.Quitter": r = "Isara"; break;
                        case "Common.Close": r = "Isara"; break;
                        case "Common.Cancel": r = "Kanselahin"; break;
                        case "Common.Add": r = "Idagdag"; break;
                        case "Common.Remove": r = "Alisin"; break;
                        case "Common.Download": r = "I-download"; break;
                        case "Common.SelectAll": r = "Piliin lahat"; break;
                        case "Common.UnselectAll": r = "Tanggalin lahat ng pagpili"; break;
                        case "Common.Save": r = "I-save"; break;
                        case "Common.Generate": r = "Bumuo"; break;
                        case "Common.Import": r = "Mag-import"; break;
                        case "Common.WorldName": r = "Pangalan ng mundo"; break;
                        case "Common.Success": r = "Tagumpay."; break;
                        case "Common.Fail": r = "Nabigo."; break;
                        case "Common.Refresh": r = "I-refresh"; break;
                        case "Common.DatapackDB": r = "Datapack Database"; break;
                        case "Common.Validate": r = "Patunayan"; break;

                        case "DatapackDB.AddDatapack": r = "Magdagdag ng datapack"; break;
                        case "DatapackDB.DelDatapack": r = "Tanggalin ang datapack"; break;
                        case "DatapackDB.InvalidDatapack": r = $"Ang item na may pangalang {item_dynamic_1} ay hindi wasto"; break;

                        case "JavaFinder.Explanation": r = "Naghahanap ng bersyon ng java na ida-download? Piliin ang iyong target na bersyon ng minecraft"; break;

                        case "RemoveJava.SelectExeFile": r = "Pumili ng java.exe file"; break;
                        case "RemoveJava.ConfirmDeleteJavaVersion": r = $"Talaga bang gusto mong tanggalin ang bersyon ng java ({item_dynamic_1}) mula sa listahan? Ito ay permanente."; break;

                        case "WorldEditor.System": r = "Sistema"; break;
                        case "WorldEditor.Custom": r = "Database"; break;
                        case "WorldEditor.GenerateNewDatapack": r = "Bumuo ng bagong datapack"; break;
                        case "WorldEditor.ErrorEmptyName": r = "Error: ang pangalan ng mundo ay hindi maaaring walang laman"; break;
                        case "WorldEditor.DatapackGeneratedDesc": r = "Datapack na binuo gamit ang MCServerCare"; break;
                        case "WorldEditor.DatapackCommentLoad": r = "isulat dito ang lahat ng mga function o command na ipapatupad sa pag-load ng datapack"; break;
                        case "WorldEditor.DatapackCommentTick": r = "isulat dito ang lahat ng mga function o command na ipapatupad sa bawat tick (20 beses kada segundo)"; break;

                        case "WorldCreator.CreationEditionWorld": r = $"Paglikha/Pag-edit ng mundo"; break;
                        case "WorldCreator.WorldName": r = $"Pangalan ng mundo:"; break;
                        case "WorldCreator.WorldAlreadyExist": r = $"Mundo na umiiral na?"; break;
                        case "WorldCreator.VerifyName": r = $"Patunayan ang pangalan."; break;
                        case "WorldCreator.GenerationPreset": r = $"Preset ng henerasyon:"; break;
                        case "WorldCreator.DatapackList": r = $"Listahan ng Datapack:"; break;
                        case "WorldCreator.DatapackBank": r = $"Bangko ng Datapack:"; break;
                        case "WorldCreator.EditWorld": r = $"I-edit ang mundo"; break;


                        case "Main.ViewDistance": r = $"Tingnan (chunk)"; break;
                        case "Main.DownloadServerJar": r = $"I-download ang .jar server"; break;
                        case "Main.UpdateServer": r = $"I-update ang server"; break;
                        case "Main.StartServer": r = $"Simulan ang server"; break;
                        case "Main.ChangeRam": r = $"Palitan ang na-allot na ram"; break;
                        case "Main.WorldCreation": r = $"Tagalikha ng mundo"; break;
                        case "Main.SwitchActiveWorld": r = $"Palitan ang aktibong mundo"; break;
                        case "Main.ChangeMOTD": r = $"Palitan ang MOTD"; break;
                        case "Main.G_System": r = $"Sistema"; break;
                        case "Main.G_Settings": r = $"Mga Setting"; break;
                        case "Main.G_Crack": r = $"Premium lamang"; break;
                        case "Main.G_Maps": r = $"Pamamahala ng mga mundo"; break;
                        case "Main.G_Range": r = $"Distansya"; break;
                        case "Main.TSMI_File": r = $"File"; break;
                        case "Main.TSMI_Info": r = $"Impormasyon"; break;
                        case "Main.LANG_Choice": r = $"Wika"; break;
                        case "Main.INFO_Version": r = $"Bersyon"; break;
                        case "Main.INFO_Changelog": r = $"Talaan ng mga pagbabago"; break;
                        case "Main.INFO_Repository": r = $"Repos ng proyekto"; break;
                        case "Main.INFO_Creator": r = $"Mga Lumikha"; break;
                        case "Main.INFO_Contributor": r = $"Mga Contributor"; break;
                        case "Main.INFO_RoadMap": r = $"Road Map"; break;
                        case "Main.JAVA_GetAnotherJava": r = $"Kumuha ng ibang bersyon ng Java"; break;
                        case "Main.JAVA_HowToInstallJava": r = $"Mag-install ng ibang bersyon ng Java"; break;
                        case "Main.JAVA_RemoveJavaInSwitcher": r = $"Pamahalaan ang mga aktibong bersyon ng Java"; break;
                        case "Main.JAVA_HowToInstallJavaTutorial": r = $"Upang mag-install ng ibang bersyon ng Java, buksan ang menu na \"Config\" ► \"Java\" ► \"Kumuha ng ibang bersyon ng Java\"\n\nPagkatapos ay punan ang form upang mahanap ang tamang bersyon ng Java na tumutugma sa target na bersyon ng Minecraft.\n\nPagkatapos ay i-download ang .zip file sa pamamagitan ng pag-click sa download.\nI-unzip ang archive na ito (inirerekumenda namin na pumili ka ng maikling landas)\n\nPagkatapos, upang idagdag ang bersyong ito ng Java sa iyong mga pagpipilian ng bersyon, kailangan mong mag-click sa icon na '+' sa kanan ng selector ng bersyon ng Java\nMagbubukas ito ng isang dialog window, kailangan mong matukoy ang java.exe file sa na-unzip na archive. Matatagpuan ang file na ito sa <pangalan ng bersyon> / bin * java.exe.\nMaaari mo ring gawin ang aksyong ito sa pamamagitan ng pagpili ng \"Config\" ► \"Java\" ► \"Pamahalaan ang mga bersyon ng Java\""; break;
                        case "Main.PLUG_Toggle": r = $"I-on/Off ang mga plugin"; break;
                        case "Main.PLUG_List": r = $"Listahan ng mga plugin"; break;
                        case "Main.PLUG_OpenFolder": r = $"Buksan ang folder ng mga plugin"; break;
                        case "Main.LabelDownloadJar": r = $"I-download ang isa sa mga server mula sa mga sumusunod na uri at palitan ang pangalan sa 'server.jar'."; break;
                        case "Main.NOTIF_MOTDChanged": r = $"Ang MOTD ay matagumpay na na-update"; break;
                        case "Main.NOTIF_Updated": r = $"nabago - "; break;
                    }
                    break;

                case "JP":
                    switch (item)
                    {
                        case "Error.DirNotExist": r = $"ディレクトリ {item_dynamic_1} は存在しません。"; break;
                        case "Error.DirAlreadyExist": r = $"ディレクトリ {item_dynamic_1} はすでに存在します。"; break;
                        case "Error.RenameError": r = $"名前の変更中にエラーが発生しました。"; break;
                        case "Erreur.NoWorld": r = $"エラー：選択された世界がありません"; break;

                        case "Common.Quitter": r = "閉じる"; break;
                        case "Common.Close": r = "閉じる"; break;
                        case "Common.Cancel": r = "キャンセル"; break;
                        case "Common.Add": r = "追加"; break;
                        case "Common.Remove": r = "削除"; break;
                        case "Common.Download": r = "ダウンロード"; break;
                        case "Common.SelectAll": r = "すべて選択"; break;
                        case "Common.UnselectAll": r = "すべての選択を解除"; break;
                        case "Common.Save": r = "保存"; break;
                        case "Common.Generate": r = "生成"; break;
                        case "Common.Import": r = "インポート"; break;
                        case "Common.WorldName": r = "ワールド名"; break;
                        case "Common.Success": r = "成功。"; break;
                        case "Common.Fail": r = "失敗。"; break;
                        case "Common.Refresh": r = "更新"; break;
                        case "Common.DatapackDB": r = "データパックデータベース"; break;
                        case "Common.Validate": r = "検証"; break;

                        case "DatapackDB.AddDatapack": r = "データパックを追加"; break;
                        case "DatapackDB.DelDatapack": r = "データパックを削除"; break;
                        case "DatapackDB.InvalidDatapack": r = $"名前が {item_dynamic_1} のアイテムは無効です"; break;

                        case "JavaFinder.Explanation": r = "ダウンロードするJavaのバージョンを探していますか？目標とするMinecraftのバージョンを選択してください"; break;

                        case "RemoveJava.SelectExeFile": r = "java.exeファイルを選択"; break;
                        case "RemoveJava.ConfirmDeleteJavaVersion": r = $"本当にJavaのバージョン（{item_dynamic_1}）をリストから削除しますか？これは永久的な操作です。"; break;

                        case "WorldEditor.System": r = "システム"; break;
                        case "WorldEditor.Custom": r = "データベース"; break;
                        case "WorldEditor.GenerateNewDatapack": r = "新しいデータパックを生成"; break;
                        case "WorldEditor.ErrorEmptyName": r = "エラー：ワールド名は空にできません"; break;
                        case "WorldEditor.DatapackGeneratedDesc": r = "MCServerCareで生成されたデータパック"; break;
                        case "WorldEditor.DatapackCommentLoad": r = "ここにデータパックのロード時に実行されるすべての関数やコマンドを書く"; break;
                        case "WorldEditor.DatapackCommentTick": r = "ここに毎ティック（1秒あたり20回）実行されるすべての関数やコマンドを書く"; break;

                        case "WorldCreator.CreationEditionWorld": r = $"ワールドの作成/編集"; break;
                        case "WorldCreator.WorldName": r = $"ワールド名："; break;
                        case "WorldCreator.WorldAlreadyExist": r = $"既存のワールド？"; break;
                        case "WorldCreator.VerifyName": r = $"名前を確認。"; break;
                        case "WorldCreator.GenerationPreset": r = $"生成プリセット："; break;
                        case "WorldCreator.DatapackList": r = $"データパックリスト："; break;
                        case "WorldCreator.DatapackBank": r = $"データパックバンク："; break;
                        case "WorldCreator.EditWorld": r = $"ワールドを編集"; break;


                        case "Main.ViewDistance": r = $"ビュー（チャンク）"; break;
                        case "Main.DownloadServerJar": r = $"サーバーの.jarをダウンロード"; break;
                        case "Main.UpdateServer": r = $"サーバーを更新"; break;
                        case "Main.StartServer": r = $"サーバーを起動"; break;
                        case "Main.ChangeRam": r = $"割り当てられたRAMを変更"; break;
                        case "Main.WorldCreation": r = $"ワールドクリエーター"; break;
                        case "Main.SwitchActiveWorld": r = $"アクティブなワールドを切り替え"; break;
                        case "Main.ChangeMOTD": r = $"MOTDを変更"; break;
                        case "Main.G_System": r = $"システム"; break;
                        case "Main.G_Settings": r = $"設定"; break;
                        case "Main.G_Crack": r = $"プレミアムのみ"; break;
                        case "Main.G_Maps": r = $"ワールド管理"; break;
                        case "Main.G_Range": r = $"範囲"; break;
                        case "Main.TSMI_File": r = $"ファイル"; break;
                        case "Main.TSMI_Info": r = $"情報"; break;
                        case "Main.LANG_Choice": r = $"言語"; break;
                        case "Main.INFO_Version": r = $"バージョン"; break;
                        case "Main.INFO_Changelog": r = $"変更履歴"; break;
                        case "Main.INFO_Repository": r = $"プロジェクトのリポジトリ"; break;
                        case "Main.INFO_Creator": r = $"クリエーター"; break;
                        case "Main.INFO_Contributor": r = $"コントリビューター"; break;
                        case "Main.INFO_RoadMap": r = $"ロードマップ"; break;
                        case "Main.JAVA_GetAnotherJava": r = $"別のJavaバージョンを取得"; break;
                        case "Main.JAVA_HowToInstallJava": r = $"別のJavaバージョンをインストールする方法"; break;
                        case "Main.JAVA_RemoveJavaInSwitcher": r = $"アクティブなJavaバージョンを管理"; break;
                        case "Main.JAVA_HowToInstallJavaTutorial": r = $"Upang mag-install ng ibang bersyon ng Java, buksan ang menu na \"Config\" ► \"Java\" ► \"Kumuha ng ibang bersyon ng Java\"\n\nPagkatapos ay punan ang form upang mahanap ang tamang bersyon ng Java na tumutugma sa target na bersyon ng Minecraft.\n\nPagkatapos ay i-download ang .zip file sa pamamagitan ng pag-click sa download.\nI-unzip ang archive na ito (inirerekumenda namin na pumili ka ng maikling landas)\n\nPagkatapos, upang idagdag ang bersyong ito ng Java sa iyong mga pagpipilian ng bersyon, kailangan mong mag-click sa icon na '+' sa kanan ng selector ng bersyon ng Java\nMagbubukas ito ng isang dialog window, kailangan mong matukoy ang java.exe file sa na-unzip na archive. Matatagpuan ang file na ito sa <pangalan ng bersyon> / bin * java.exe.\nMaaari mo ring gawin ang aksyong ito sa pamamagitan ng pagpili ng \"Config\" ► \"Java\" ► \"Pamahalaan ang mga bersyon ng Java\""; break;
                        case "Main.PLUG_Toggle": r = $"プラグインの有効/無効"; break;
                        case "Main.PLUG_List": r = $"プラグインリスト"; break;
                        case "Main.PLUG_OpenFolder": r = $"プラグインフォルダを開く"; break;
                        case "Main.LabelDownloadJar": r = $"次のタイプからサーバーをダウンロードし、名前を 'server.jar' に変更します。"; break;
                        case "Main.NOTIF_MOTDChanged": r = $"MOTDは正常に更新されました"; break;
                        case "Main.NOTIF_Updated": r = $"変更されました - "; break;
                    }
                    break;

                case "RU":
                    switch (item)
                    {
                        case "Error.DirNotExist": r = $"Директория {item_dynamic_1} не существует."; break;
                        case "Error.DirAlreadyExist": r = $"Директория {item_dynamic_1} уже существует."; break;
                        case "Error.RenameError": r = $"Ошибка при переименовании."; break;
                        case "Erreur.NoWorld": r = $"Ошибка, мир не выбран"; break;

                        case "Common.Quitter": r = "Закрыть"; break;
                        case "Common.Close": r = "Закрыть"; break;
                        case "Common.Cancel": r = "Отмена"; break;
                        case "Common.Add": r = "Добавить"; break;
                        case "Common.Remove": r = "Удалить"; break;
                        case "Common.Download": r = "Скачать"; break;
                        case "Common.SelectAll": r = "Выбрать все"; break;
                        case "Common.UnselectAll": r = "Снять все отметки"; break;
                        case "Common.Save": r = "Сохранить"; break;
                        case "Common.Generate": r = "Сгенерировать"; break;
                        case "Common.Import": r = "Импортировать"; break;
                        case "Common.WorldName": r = "Название мира"; break;
                        case "Common.Success": r = "Успех."; break;
                        case "Common.Fail": r = "Неудача."; break;
                        case "Common.Refresh": r = "Обновить"; break;
                        case "Common.DatapackDB": r = "База данных Datapack"; break;
                        case "Common.Validate": r = "Подтвердить"; break;

                        case "DatapackDB.AddDatapack": r = "Добавить datapack"; break;
                        case "DatapackDB.DelDatapack": r = "Удалить datapack"; break;
                        case "DatapackDB.InvalidDatapack": r = $"Элемент с именем {item_dynamic_1} недействителен"; break;

                        case "JavaFinder.Explanation": r = "Ищете версию Java для загрузки? Выберите вашу целевую версию Minecraft"; break;

                        case "RemoveJava.SelectExeFile": r = "Выберите файл java.exe"; break;
                        case "RemoveJava.ConfirmDeleteJavaVersion": r = $"Вы действительно хотите удалить версию Java ({item_dynamic_1}) из списка? Это действие нельзя отменить."; break;

                        case "WorldEditor.System": r = "Система"; break;
                        case "WorldEditor.Custom": r = "База данных"; break;
                        case "WorldEditor.GenerateNewDatapack": r = "Создать новый datapack"; break;
                        case "WorldEditor.ErrorEmptyName": r = "Ошибка: имя мира не может быть пустым"; break;
                        case "WorldEditor.DatapackGeneratedDesc": r = "Datapack сгенерирован с помощью MCServerCare"; break;
                        case "WorldEditor.DatapackCommentLoad": r = "здесь напишите все функции или команды, которые будут выполняться при загрузке datapack"; break;
                        case "WorldEditor.DatapackCommentTick": r = "здесь напишите все функции или команды, которые будут выполняться каждый тик (20 раз в секунду)"; break;

                        case "WorldCreator.CreationEditionWorld": r = $"Создание/Редактирование мира"; break;
                        case "WorldCreator.WorldName": r = $"Название мира:"; break;
                        case "WorldCreator.WorldAlreadyExist": r = $"Мир уже существует?"; break;
                        case "WorldCreator.VerifyName": r = $"Проверить имя."; break;
                        case "WorldCreator.GenerationPreset": r = $"Пресет генерации:"; break;
                        case "WorldCreator.DatapackList": r = $"Список Datapack:"; break;
                        case "WorldCreator.DatapackBank": r = $"Банк Datapack:"; break;
                        case "WorldCreator.EditWorld": r = $"Редактировать мир"; break;


                        case "Main.ViewDistance": r = $"Видимость (чанк)"; break;
                        case "Main.DownloadServerJar": r = $"Скачать .jar сервера"; break;
                        case "Main.UpdateServer": r = $"Обновить сервер"; break;
                        case "Main.StartServer": r = $"Запустить сервер"; break;
                        case "Main.ChangeRam": r = $"Изменить выделенный RAM"; break;
                        case "Main.WorldCreation": r = $"Создатель мира"; break;
                        case "Main.SwitchActiveWorld": r = $"Сменить активный мир"; break;
                        case "Main.ChangeMOTD": r = $"Изменить MOTD"; break;
                        case "Main.G_System": r = $"Система"; break;
                        case "Main.G_Settings": r = $"Настройки"; break;
                        case "Main.G_Crack": r = $"Только премиум"; break;
                        case "Main.G_Maps": r = $"Управление мирами"; break;
                        case "Main.G_Range": r = $"Диапазон"; break;
                        case "Main.TSMI_File": r = $"Файл"; break;
                        case "Main.TSMI_Info": r = $"Информация"; break;
                        case "Main.LANG_Choice": r = $"Язык"; break;
                        case "Main.INFO_Version": r = $"Версия"; break;
                        case "Main.INFO_Changelog": r = $"Журнал изменений"; break;
                        case "Main.INFO_Repository": r = $"Репозиторий проекта"; break;
                        case "Main.INFO_Creator": r = $"Создатели"; break;
                        case "Main.INFO_Contributor": r = $"Участники"; break;
                        case "Main.INFO_RoadMap": r = $"Дорожная карта"; break;
                        case "Main.JAVA_GetAnotherJava": r = $"Получить другую версию Java"; break;
                        case "Main.JAVA_HowToInstallJava": r = $"Установить другую версию Java"; break;
                        case "Main.JAVA_RemoveJavaInSwitcher": r = $"Управление активными версиями Java"; break;
                        case "Main.JAVA_HowToInstallJavaTutorial": r = $"Upang mag-install ng ibang bersyon ng Java, buksan ang menu na \"Config\" ► \"Java\" ► \"Kumuha ng ibang bersyon ng Java\"\n\nPagkatapos ay punan ang form upang mahanap ang tamang bersyon ng Java na tumutugma sa target na bersyon ng Minecraft.\n\nPagkatapos ay i-download ang .zip file sa pamamagitan ng pag-click sa download.\nI-unzip ang archive na ito (inirerekumenda namin na pumili ka ng maikling landas)\n\nPagkatapos, upang idagdag ang bersyong ito ng Java sa iyong mga pagpipilian ng bersyon, kailangan mong mag-click sa icon na '+' sa kanan ng selector ng bersyon ng Java\nMagbubukas ito ng isang dialog window, kailangan mong matukoy ang java.exe file sa na-unzip na archive. Matatagpuan ang file na ito sa <pangalan ng bersyon> / bin * java.exe.\nMaaari mo ring gawin ang aksyong ito sa pamamagitan ng pagpili ng \"Config\" ► \"Java\" ► \"Pamahalaan ang mga bersyon ng Java\""; break;
                        case "Main.PLUG_Toggle": r = $"Включить/Выключить плагины"; break;
                        case "Main.PLUG_List": r = $"Список плагинов"; break;
                        case "Main.PLUG_OpenFolder": r = $"Открыть папку плагинов"; break;
                        case "Main.LabelDownloadJar": r = $"Скачайте один из серверов из следующих типов и переименуйте в 'server.jar'."; break;
                        case "Main.NOTIF_MOTDChanged": r = $"MOTD был успешно обновлен"; break;
                        case "Main.NOTIF_Updated": r = $"изменено - "; break;
                    }
                    break;

            }
            return r;
        }
    }
    public partial class ServerManager : Form
    {
        # region tr
        public void makeTranslation(string languageCode)
        {
            FULL_APP_LANGUAGE = languageCode;
            SetProfileValue("langue", languageCode);
            translationGlobale();
        }
        private void ChangeLanguage(object sender, EventArgs e)
        {
            makeTranslation((sender as ToolStripMenuItem).Tag.ToString());
        }
        #endregion tr
        public void translationGlobale()
        {
            //label
            lblViewDistance.Text = Traduction.TranslateByCode("Main.ViewDistance");

            #region Boutons

            //boutons systemes
            btnDownloadServJar.Text = Traduction.TranslateByCode("Main.DownloadServerJar");
            btnUpdateServer.Text = Traduction.TranslateByCode("Main.UpdateServer");
            btnStartServer.Text = Traduction.TranslateByCode("Main.StartServer");

            //boutons paramètres
            lblRam.Text = Traduction.TranslateByCode("Main.ChangeRam");

            #endregion
            #region maps
            //Maps
            btnWorldCreation.Text = Traduction.TranslateByCode("Main.WorldCreation");
            btnWorldSelection.Text = Traduction.TranslateByCode("Main.SwitchActiveWorld");
            #endregion
            //MOTD
            btnMOTD.Text = Traduction.TranslateByCode("Main.ChangeMOTD");
            #region groupes
            //---Groupes
            gbSystem.Text = Traduction.TranslateByCode("Main.G_System");
            gbSettings.Text = Traduction.TranslateByCode("Main.G_Settings");
            gbCracks.Text = Traduction.TranslateByCode("Main.G_Crack");
            gbWhitelist.Text = "Whitelist";
            gbPvp.Text = "PvP";
            gbCommandBlock.Text = "CommandBlocks";
            gbHardcore.Text = "Hardcore";
            gbMaps.Text = Traduction.TranslateByCode("Main.G_Maps");
            gbDistances.Text = Traduction.TranslateByCode("Main.G_Range");
            gbMOTD.Text = "MOTD";
            #endregion
            //---Menu

            //-Fichier
            //Head
            fichierToolStripMenuItem.Text = Traduction.TranslateByCode("Main.TSMI_File");
            //Items
            quitterToolStripMenuItem.Text = Traduction.TranslateByCode("Common.Quitter");
            rechargerToolStripMenuItem.Text = Traduction.TranslateByCode("Common.Refresh");

            getOtherJavaVersionToolStripMenuItem.Text = Traduction.TranslateByCode("Main.JAVA_GetAnotherJava");
            howToInstallOtherJavaVerToolStripMenuItem.Text = Traduction.TranslateByCode("Main.JAVA_HowToInstallJava");
            removeJavaFromJavaSwitcherToolStripMenuItem.Text = Traduction.TranslateByCode("Main.JAVA_RemoveJavaInSwitcher");

            togglePluginsToolStripMenuItem.Text = Traduction.TranslateByCode("Main.PLUG_Toggle");
            pluginListToolStripMenuItem.Text = Traduction.TranslateByCode("Main.PLUG_List");
            openPluginsFolderToolStripMenuItem.Text = Traduction.TranslateByCode("Main.PLUG_OpenFolder");

            #region langue
            //Head
            langueToolStripMenuItem.Text = Traduction.TranslateByCode("Main.LANG_Choice");
            //Items
            françaisToolStripMenuItem.Text = "Français";
            anglaisToolStripMenuItem.Text = "English";
            allemandToolStripMenuItem.Text = "Deutsche";
            espagnolToolStripMenuItem.Text = "Español";
            italienToolStripMenuItem.Text = "Italiano";
            japonaisToolStripMenuItem.Text = "日本語";
            portugaisToolStripMenuItem.Text = "Português";
            suedoisToolStripMenuItem.Text = "Svenska";
            philipinToolStripMenuItem.Text = "Filipino";
            russeToolStripMenuItem.Text = "Русский";
            #endregion
            #region info
            //Head
            infosToolStripMenuItem.Text = Traduction.TranslateByCode("Main.TSMI_Info");
            //Items
            versionToolStripMenuItem.Text = Traduction.TranslateByCode("Main.INFO_Version");
            changelogToolStripMenuItem.Text = Traduction.TranslateByCode("Main.INFO_Changelog");
            reposToolStripMenuItem.Text = Traduction.TranslateByCode("Main.INFO_Repository");
            créateursToolStripMenuItem.Text = Traduction.TranslateByCode("Main.INFO_Creator");
            contributeursToolStripMenuItem.Text = Traduction.TranslateByCode("Main.INFO_Contributor");
            roadMapToolStripMenuItem.Text = Traduction.TranslateByCode("Main.INFO_RoadMap");
            #endregion
            //Specials items label
            labelDownloadJar = Traduction.TranslateByCode("Main.LabelDownloadJar");
            motdChanged = Traduction.TranslateByCode("Main.NOTIF_MOTDChanged");
            Updated = Traduction.TranslateByCode("Main.NOTIF_Updated");
            noWorld = Traduction.TranslateByCode("Erreur.NoWorld");

        }
    }
}

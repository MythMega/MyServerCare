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
                    }
                    break;
            }
            return r;
        }
    }
    public partial class ServerManager : Form
    {
        public void makeTranslation(string languageCode)
        {
            FULL_APP_LANGUAGE = languageCode;
            switch (languageCode)
            {
                case "FR":
                    translationFR();
                    SetProfileValue("langue", "FR");
                    break;
                case "EN":
                    translationEN();
                    SetProfileValue("langue", "EN");
                    break;
                case "DE":
                    translationDE();
                    SetProfileValue("langue", "DE");
                    break;
                case "ES":
                    translationES();
                    SetProfileValue("langue", "ES");
                    break;
            }
        }



        private void françaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeTranslation("FR");
        }

        private void anglaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeTranslation("EN");
        }

        private void allemandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeTranslation("DE");
        }

        private void espagnolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeTranslation("ES");
        }


        public void translationFR()
        {
            // DEBUT TRADUCTION
            //label
            lblViewDistance.Text = "Vue (chunk)";

            //---Boutons

            //boutons systemes
            btnDownloadServJar.Text = "Télécharger serveur";
            btnUpdateServer.Text = "Mettre à jour Serveur";
            btnStartServer.Text = "Démarrer Serveur";

            //boutons paramètres
            lblRam.Text = "Changer RAM";

            //Maps
            btnWorldCreation.Text = "Gestion des mondes";
            btnWorldSelection.Text = "Changer de monde";


            //MOTD
            btnMOTD.Text = "changer MOTD";

            //---Groupes
            gbSystem.Text = "Système";
            gbSettings.Text = "Paramètres";
            gbCracks.Text = "Premium Only";
            gbWhitelist.Text = "Whitelist";
            gbPvp.Text = "PvP";
            gbCommandBlock.Text = "CommandBlock";
            gbHardcore.Text = "Hardcore";
            gbMaps.Text = "Gestion de maps";
            gbDistances.Text = "Distances";
            gbMOTD.Text = "MOTD";

            //---Menu

            //-Fichier
            //Head
            fichierToolStripMenuItem.Text = "Fichier";
            //Items
            quitterToolStripMenuItem.Text = "Quitter";
            rechargerToolStripMenuItem.Text = "Recharger";

            //-Langue
            //Head
            langueToolStripMenuItem.Text = "Langue";
            //Items
            françaisToolStripMenuItem.Text = "Français";
            anglaisToolStripMenuItem.Text = "English";
            allemandToolStripMenuItem.Text = "Deutsch";
            espagnolToolStripMenuItem.Text = "Español";

            //-Infos
            //Head
            infosToolStripMenuItem.Text = "Infos";
            //Items
            versionToolStripMenuItem.Text = "Version";
            changelogToolStripMenuItem.Text = "Changelog";
            reposToolStripMenuItem.Text = "Repository";
            créateursToolStripMenuItem.Text = "Créateurs";

            //Specials items label
            labelDownloadJar = "Télécharger l'un des serveur parmis les types suivants et renommez 'server.jar' .";
            motdChanged = "Le MOTD a bien été mis a jour.";
            Updated = "MODIFIÉ - ";
            noWorld = "Erreur, aucun monde selectionné";

        }

        public void translationEN()
        {
            // DEBUT TRADUCTION

            //label
            lblViewDistance.Text = "View (chunk)";

            //---Boutons

            //boutons systemes
            btnDownloadServJar.Text = "Download Server";
            btnUpdateServer.Text = "Update server";
            btnStartServer.Text = "Start server";

            //boutons paramètres
            lblRam.Text = "Edit RAM";

            //Maps
            btnWorldCreation.Text = "Maps management";
            btnWorldSelection.Text = "Switch active map";

            //MOTD
            btnMOTD.Text = "change MOTD";

            //---Groupes
            gbSystem.Text = "System";
            gbSettings.Text = "Settings";
            gbCracks.Text = "Premium Only";
            gbWhitelist.Text = "Whitelist";
            gbPvp.Text = "PvP";
            gbCommandBlock.Text = "CommandBlock";
            gbHardcore.Text = "Hardcore";
            gbMaps.Text = "Maps management";
            gbDistances.Text = "Distances";
            gbMOTD.Text = "MOTD";

            //---Menu

            //-Fichier
            //Head
            fichierToolStripMenuItem.Text = "File";
            //Items
            quitterToolStripMenuItem.Text = "Quit";
            rechargerToolStripMenuItem.Text = "Reload";

            //-Langue
            //Head
            langueToolStripMenuItem.Text = "Language";
            //Items
            françaisToolStripMenuItem.Text = "Français";
            anglaisToolStripMenuItem.Text = "English";
            allemandToolStripMenuItem.Text = "Deutsch";
            espagnolToolStripMenuItem.Text = "Español";

            //-Infos
            //Head
            infosToolStripMenuItem.Text = "Infos";
            //Items
            versionToolStripMenuItem.Text = "Version";
            changelogToolStripMenuItem.Text = "Changelog";
            reposToolStripMenuItem.Text = "Repository";
            créateursToolStripMenuItem.Text = "Creators";

            //Specials items label
            labelDownloadJar = "Download jar from theses type, and rename it 'server.jar' .";
            motdChanged = "MOTD has been updated.";
            Updated = "UPDATED - ";
            noWorld = "Error, no world selectionned";
        }

        public void translationDE()
        {
            // DEBUT TRADUCTION

            //label
            lblViewDistance.Text = "Ansicht (Chunks)";

            //---Boutons

            //boutons systemes
            btnDownloadServJar.Text = "Server herunterladen";
            btnUpdateServer.Text = "Server aktualisieren";
            btnStartServer.Text = "Server starten";

            //boutons paramètres
            lblRam.Text = "RAM bearbeiten";

            //Maps
            btnWorldCreation.Text = "Kartenverwaltung";
            btnWorldSelection.Text = "Aktive Karte wechseln";

            //MOTD
            btnMOTD.Text = "MOTD ändern";

            //---Groupes
            gbSystem.Text = "System";
            gbSettings.Text = "Einstellungen";
            gbCracks.Text = "Premium Only";
            gbWhitelist.Text = "Whitelist";
            gbPvp.Text = "PvP";
            gbCommandBlock.Text = "Befehlsblock";
            gbHardcore.Text = "Hardcore";
            gbMaps.Text = "Kartenverwaltung";
            gbDistances.Text = "Entfernungen";
            gbMOTD.Text = "MOTD";

            //---Menu

            //-Fichier
            //Head
            fichierToolStripMenuItem.Text = "Datei";
            //Items
            quitterToolStripMenuItem.Text = "Beenden";
            rechargerToolStripMenuItem.Text = "Neu laden";

            //-Langue
            //Head
            langueToolStripMenuItem.Text = "Sprache";
            //Items
            françaisToolStripMenuItem.Text = "Français";
            anglaisToolStripMenuItem.Text = "English";
            allemandToolStripMenuItem.Text = "Deutsch";
            espagnolToolStripMenuItem.Text = "Español";

            //-Infos
            //Head
            infosToolStripMenuItem.Text = "Informationen";
            //Items
            versionToolStripMenuItem.Text = "Version";
            changelogToolStripMenuItem.Text = "Änderungsprotokoll";
            reposToolStripMenuItem.Text = "Repository";
            créateursToolStripMenuItem.Text = "Schöpfer";

            //Specials items label
            labelDownloadJar = "Laden Sie ein Jar von diesen Typen herunter und benennen Sie es in 'server.jar' um.";
            motdChanged = "MOTD wurde aktualisiert.";
            Updated = "AKTUALISIERT - ";
            noWorld = "Fehler, keine Welt ausgewählt";
        }

        public void translationES()
        {
            // DEBUT TRADUCTION

            //label
            lblViewDistance.Text = "Vista (Chunks)";

            //---Boutons

            //boutons systemes
            btnDownloadServJar.Text = "Descargar servidor";
            btnUpdateServer.Text = "Actualizar servidor";
            btnStartServer.Text = "Iniciar servidor";

            //boutons paramètres
            lblRam.Text = "Editar RAM";

            //Maps
            btnWorldCreation.Text = "Gestión de mapas";
            btnWorldSelection.Text = "Cambiar mapa activo";

            //MOTD
            btnMOTD.Text = "Cambiar MOTD";

            //---Groupes
            gbSystem.Text = "Sistema";
            gbSettings.Text = "Configuración";
            gbCracks.Text = "Premium Only";
            gbWhitelist.Text = "Lista blanca";
            gbPvp.Text = "PvP";
            gbCommandBlock.Text = "Bloque de comandos";
            gbHardcore.Text = "Modo hardcore";
            gbMaps.Text = "Gestión de mapas";
            gbDistances.Text = "Distancias";
            gbMOTD.Text = "MOTD";

            //---Menu

            //-Fichier
            //Head
            fichierToolStripMenuItem.Text = "Archivo";
            //Items
            quitterToolStripMenuItem.Text = "Salir";
            rechargerToolStripMenuItem.Text = "Recargar";

            //-Langue
            //Head
            langueToolStripMenuItem.Text = "Idioma";
            //Items
            françaisToolStripMenuItem.Text = "Français";
            anglaisToolStripMenuItem.Text = "English";
            allemandToolStripMenuItem.Text = "Deutsch";
            espagnolToolStripMenuItem.Text = "Español";

            //-Infos
            //Head
            infosToolStripMenuItem.Text = "Información";
            //Items
            versionToolStripMenuItem.Text = "Versión";
            changelogToolStripMenuItem.Text = "Registro de cambios";
            reposToolStripMenuItem.Text = "Repositorio";
            créateursToolStripMenuItem.Text = "Creadores";

            //Specials items label
            labelDownloadJar = "Descargue un archivo Jar de estos tipos y cambie su nombre a 'server.jar'.";
            motdChanged = "El MOTD ha sido actualizado.";
            Updated = "ACTUALIZADO - ";
            noWorld = "Error, no se ha seleccionado ningún mundo";
        }
    }
}

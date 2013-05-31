using System.IO;
using System.Windows;
using SharpSetup.Base;
using SharpSetup.Prerequisites.Base;

namespace Gui
{
    /// <summary>
    /// Interaction logic for InstallationStep.xaml
    /// </summary>
    public partial class InstallationStep
    {
        InstallationMode mode;
        public InstallationStep(InstallationMode mode)
        {
            InitializeComponent();
            this.mode = mode;
        }

        private void InstallationStep_Entered(object sender, SharpSetup.UI.Wpf.Base.ChangeStepRoutedEventArgs e)
        {
            try
            {
                if (mode == InstallationMode.Uninstall)
                {
                    MsiConnection.Instance.Uninstall();
                    
                    /*
                    try
                    {
                        MsiConnection.Instance.Open(new Guid("{84c7dd22-35c0-4fc9-a33d-1cf5c65b3e47}"), false);
                        MsiConnection.Instance.Uninstall();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Uninstall");
                    }
                    */
                    if (File.Exists(Properties.Resources.MainMsiFile))
                        MsiConnection.Instance.Open(Properties.Resources.MainMsiFile, true);
                }
                else if (mode == InstallationMode.Install)
                {
                    PrerequisiteManager.Instance.Install();
                    /*
                    MsiConnection.Instance.SaveAs("MainInstall");
                    MsiConnection.Instance.EnableSettingsChanged = false;
                    MsiConnection.Instance.Open("other.msi", false);
                    MsiConnection.Instance.Install("");
                    MsiConnection.Instance.OpenSaved("MainInstall");
                    */

                    
                    try
                    {
                        InstallVariables.InstallRoot = MsiConnection.Instance.GetProperty("INSTALLLOCATION");
                    }
                    catch
                    {
                        // Best effort to fetch product code, if not present we have big issues ;(
                        MessageBox.Show("Cannot locate product code to continue install.");
                        Wizard.Finish();
                    }

                    MsiConnection.Instance.Install();

                }
                else
                    MessageBox.Show("Unknown mode");
            }
            catch (MsiException mex)
            {
                if (mex.ErrorCode != (uint)InstallError.UserExit)
                    MessageBox.Show("Installation failed: " + mex.Message);
                Wizard.Finish();
            }

            Wizard.NextStep();
        }
    }
}

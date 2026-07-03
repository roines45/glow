using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
//
using static Glow.TSModules;

namespace Glow.glow_tools{
    public partial class GlowNetworkFixTool : Form{
        public GlowNetworkFixTool(){ InitializeComponent(); }
        // PRE-LOAD
        // ======================================================================================================
        public void GTool_NetworkFix_Preloader(){
            try{
                TSThemeModeHelper.InitializeThemeForForm(this);
                //
                BackColor = TS_ThemeEngine.ColorMode(GlowMain.theme, "TSBT_BGColor2");
                //
                Panel_BG.BackColor = TS_ThemeEngine.ColorMode(GlowMain.theme, "TSBT_BGColor");
                //
                NFT_TitleLabel.BackColor = TS_ThemeEngine.ColorMode(GlowMain.theme, "TSBT_BGColor2");
                NFT_TitleLabel.ForeColor = TS_ThemeEngine.ColorMode(GlowMain.theme, "TSBT_LabelColor1");
                //
                NFT_ResultList.BackColor = TS_ThemeEngine.ColorMode(GlowMain.theme, "TSBT_BGColor2");
                NFT_ResultList.ForeColor = TS_ThemeEngine.ColorMode(GlowMain.theme, "TSBT_LabelColor1");
                NFT_ResultList.SelectedBackColor = TS_ThemeEngine.ColorMode(GlowMain.theme, "TSBT_AccentColor");
                NFT_ResultList.SelectedForeColor = TS_ThemeEngine.ColorMode(GlowMain.theme, "TSBT_BGColor2");
                //
                NFT_StartBtn.BackColor = TS_ThemeEngine.ColorMode(GlowMain.theme, "TSBT_AccentColor");
                NFT_StartBtn.ForeColor = TS_ThemeEngine.ColorMode(GlowMain.theme, "TSBT_BGColor2");
                NFT_StartBtn.FlatAppearance.BorderColor = TS_ThemeEngine.ColorMode(GlowMain.theme, "TSBT_AccentColor");
                NFT_StartBtn.FlatAppearance.MouseDownBackColor = TS_ThemeEngine.ColorMode(GlowMain.theme, "TSBT_AccentColor");
                NFT_StartBtn.FlatAppearance.MouseOverBackColor = TS_ThemeEngine.ColorMode(GlowMain.theme, "AccentColorHover");
                //
                TSImageRenderer(NFT_StartBtn, GlowMain.theme == 1 ? Properties.Resources.ct_fix_light : Properties.Resources.ct_fix_dark, 18, ContentAlignment.MiddleRight);
                // TEXT
                // ----------------------
                TSGetLangs software_lang = new TSGetLangs(GlowMain.lang_path);
                Text = string.Format(software_lang.TSReadLangs("NetworkFixTool", "nft_title"), Application.ProductName);
                //
                NFT_StartBtn.Text = " " + software_lang.TSReadLangs("NetworkFixTool", "nft_process_start_btn");
            }catch (Exception ex){
                if (GlowMain.debug_status) { TSErrorLog.LogException(ex, "GTool_NetworkFix_Preloader()"); }
            }
        }
        // LOAD
        // ======================================================================================================
        private void GlowNetworkFixTool_Load(object sender, EventArgs e){
            try{
                GTool_NetworkFix_Preloader();
                //
                TSGetLangs software_lang = new TSGetLangs(GlowMain.lang_path);
                NFT_TitleLabel.Text = software_lang.TSReadLangs("NetworkFixTool", "nft_title_label_before_start");
            }catch (Exception ex){
                if (GlowMain.debug_status) { TSErrorLog.LogException(ex, "GlowNetworkFixTool_Load()"); }
            }
        }
        // RESULT LIST CLEAR SELECTION
        // ======================================================================================================
        private void NFT_ResultList_SelectedIndexChanged(object sender, EventArgs e){
            NFT_ResultList.SelectedIndex = -1;
            NFT_ResultList.ClearSelected();
        }
        // NETWORK FIX ENGINE STARTER BTN
        // ======================================================================================================
        private async void NFT_StartBtn_Click(object sender, EventArgs e){
            try{
                TSGetLangs software_lang = new TSGetLangs(GlowMain.lang_path);
                DialogResult start_engine_query = TS_MessageBoxEngine.TS_MessageBox(this, 6, string.Format(software_lang.TSReadLangs("NetworkFixTool", "nft_process_start_query"), "\n"));
                if (start_engine_query == DialogResult.Yes){
                    await Start_network_fix_engine_async();
                    NFT_TitleLabel.Text = software_lang.TSReadLangs("NetworkFixTool", "nft_title_label_in_process");
                }
            }catch (Exception ex){
                if (GlowMain.debug_status) { TSErrorLog.LogException(ex, "NFT_StartBtn_Click()"); }
            }
        }
        // NETWORK FIX ENGINE STARTER
        // ======================================================================================================
        private async Task Start_network_fix_engine_async(){
            try{
                NFT_ResultList.Items.Clear();
                NFT_StartBtn.Enabled = false;
                await Ts_RunNetworkFixCommandAsync("netsh", "winsock reset");
                await Ts_RunNetworkFixCommandAsync("netsh", "int ip reset");
                await Ts_RunNetworkFixCommandAsync("ipconfig", "/release");
                await Ts_RunNetworkFixCommandAsync("ipconfig", "/renew");
                await Ts_RunNetworkFixCommandAsync("ipconfig", "/flushdns");
                if (this.IsDisposed || !this.IsHandleCreated) return;
                TSGetLangs software_lang = new TSGetLangs(GlowMain.lang_path);
                NFT_TitleLabel.Text = software_lang.TSReadLangs("NetworkFixTool", "nft_title_label_after_end");
                NFT_StartBtn.Enabled = true;
                DialogResult end_engine_query = TS_MessageBoxEngine.TS_MessageBox(this, 6, string.Format(software_lang.TSReadLangs("NetworkFixTool", "nft_process_after_query"), "\n\n", "\n\n", "\n\n"));
                if (end_engine_query == DialogResult.Yes){
                    try{
                        ProcessStartInfo pc_restart_query = new ProcessStartInfo{
                            FileName = "shutdown",
                            Arguments = "/r /t 0",
                            CreateNoWindow = true,
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            RedirectStandardError = true
                        };
                        using (Process pc_restart_starter = Process.Start(pc_restart_query)){
                            if (pc_restart_starter != null){
                                await Task.Run(() => pc_restart_starter.WaitForExit());
                            }
                        }
                    }catch (Exception){
                        if (this.IsDisposed || !this.IsHandleCreated) return;
                        TS_MessageBoxEngine.TS_MessageBox(this, 3, string.Format(software_lang.TSReadLangs("NetworkFixTool", "nft_process_after_restart_info"), "\n"));
                    }
                }
            }catch (Exception ex){
                if (GlowMain.debug_status) { TSErrorLog.LogException(ex, "Start_network_fix_engine_async()"); }
            }
        }
        // NETWORK FIX ENGINE
        // ======================================================================================================
        private async Task Ts_RunNetworkFixCommandAsync(string get_command, string get_arguments){
            try{
                string currentLangPath = GlowMain.lang_path;
                await Task.Run(() => {
                    ProcessStartInfo start_network_fix_process = new ProcessStartInfo{
                        FileName = "cmd.exe",
                        Arguments = $"/c {get_command} {get_arguments}",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    using (Process network_fix_runner = Process.Start(start_network_fix_process)){
                        string get_result = network_fix_runner.StandardOutput.ReadToEnd();
                        string get_error = network_fix_runner.StandardError.ReadToEnd();
                        network_fix_runner.WaitForExit();
                        int exitCode = network_fix_runner.ExitCode;
                        TSGetLangs software_lang = new TSGetLangs(currentLangPath);
                        if (this.IsDisposed) return;
                        this.BeginInvoke(new Action(() => {
                            if (this.IsDisposed || !this.IsHandleCreated) return;
                            if (exitCode == 0){
                                NFT_ResultList.Items.Add(string.Format(software_lang.TSReadLangs("NetworkFixTool", "nft_process_code_transfer"), get_command, get_arguments));
                            }else{
                                string errText = !string.IsNullOrWhiteSpace(get_error) ? get_error.Trim() : (!string.IsNullOrWhiteSpace(get_result) ? get_result.Trim() : $"ExitCode: {exitCode}");
                                NFT_ResultList.Items.Add(string.Format(software_lang.TSReadLangs("NetworkFixTool", "nft_process_code_transfer_error"), get_command, get_arguments, errText));
                            }
                        }));
                    }
                });
            }catch (Exception ex){
                if (GlowMain.debug_status) { TSErrorLog.LogException(ex, "Ts_RunNetworkFixCommandAsync()"); }
            }
        }
    }
}
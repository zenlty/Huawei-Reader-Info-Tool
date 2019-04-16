using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MaterialSkin;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Huawei_Reader_Tool_by_GSMTurkey
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

        }
        string tmpDir = Application.StartupPath,
        appPath = AppDomain.CurrentDomain.BaseDirectory,
        comPort = null,
        programmerPrefix = null;
        int Default = 1,
            Error = 2,
            Success = 3,
            Warning = 4,
            Threads = 0;
        bool Connected = false;

        ListViewItem lastItemChecked;
        List<string> devices = new List<string>();
        private int devicemode = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            log.SelectionChanged += log_disableSelection;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; //Green600

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green300, Primary.Green300, Primary.Green300, Accent.Red700, TextShade.BLACK);
            writeLog("Program Başlatıldı", Warning);


        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            devicechecker();
            if (devicemode == 0)
            {
                writeLog("Cihazı bağlamanız bekleniyor", Warning);
            }
            if (devicemode == 1)
            {
                writeLog("Cihaz fastboot moduna alınıyor...", Warning);
                Process process2 = new Process();
                ProcessStartInfo startInfo2 = new ProcessStartInfo();
                startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo2.CreateNoWindow = true;
                startInfo2.UseShellExecute = false;
                startInfo2.RedirectStandardOutput = true;
                startInfo2.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                startInfo2.Arguments = "reboot bootloader";
                process2.StartInfo = startInfo2;
                process2.Start();
                process2.WaitForExit();
                if (devicemode == 0)
                {
                    writeLog("Cihazınız fastboot moduna alınamadı", Error);
                }
                if (devicemode == 2)
                {
                    writeLog("Cihazınız fastboot moduna başarıyla alındı", Error);
                    ilkadim();
                }
            }
            if (devicemode == 2)
            {
                ilkadim();
            }




        }
        private void devicechecker()
        {
            console.Clear();
            {
                {

                    {

                        Process process = new Process();
                        Process process2 = new Process();
                        Process process3 = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        ProcessStartInfo startInfo2 = new ProcessStartInfo();
                        ProcessStartInfo startInfo3 = new ProcessStartInfo();
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                        startInfo3.WindowStyle = ProcessWindowStyle.Hidden;
                        startInfo.CreateNoWindow = true;
                        startInfo2.CreateNoWindow = true;
                        startInfo3.CreateNoWindow = true;
                        startInfo.UseShellExecute = false;
                        startInfo2.UseShellExecute = false;
                        startInfo3.UseShellExecute = false;
                        startInfo.RedirectStandardOutput = true;
                        startInfo2.RedirectStandardOutput = true;
                        startInfo3.RedirectStandardOutput = true;
                        startInfo.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                        startInfo2.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                        startInfo3.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                        startInfo.Arguments = " shell getprop ro.product.model ";
                        startInfo2.Arguments = " shell getprop ro.product.manufacturer ";
                        startInfo3.Arguments = " shell getprop ro.build.version.release";
                        process.StartInfo = startInfo;
                        process2.StartInfo = startInfo2;
                        process3.StartInfo = startInfo3;
                        process.Start();
                        process2.Start();
                        process3.Start();
                        label8.Text = process.StandardOutput.ReadToEnd();
                        label10.Text = process2.StandardOutput.ReadToEnd();
                        label13.Text = process3.StandardOutput.ReadToEnd();
                        if (label10.Text != "Cihaz Bağlı Değil")
                        {
                            Process aprocess = new Process();
                            Process aprocess2 = new Process();
                            Process aprocess3 = new Process();
                            Process process4 = new Process();
                            Process process5 = new Process();
                            Process process6 = new Process();
                            Process process7 = new Process();
                            Process process8 = new Process();
                            Process process9 = new Process();
                            Process process10 = new Process();
                            Process process11 = new Process();
                            Process process12 = new Process();
                            ProcessStartInfo astartInfo = new ProcessStartInfo();
                            ProcessStartInfo astartInfo2 = new ProcessStartInfo();
                            ProcessStartInfo astartInfo3 = new ProcessStartInfo();
                            ProcessStartInfo startInfo4 = new ProcessStartInfo();
                            ProcessStartInfo startInfo5 = new ProcessStartInfo();
                            ProcessStartInfo startInfo6 = new ProcessStartInfo();
                            ProcessStartInfo startInfo7 = new ProcessStartInfo();
                            ProcessStartInfo startInfo8 = new ProcessStartInfo();
                            ProcessStartInfo startInfo9 = new ProcessStartInfo();
                            ProcessStartInfo startInfo10 = new ProcessStartInfo();
                            ProcessStartInfo startInfo11 = new ProcessStartInfo();
                            ProcessStartInfo startInfo12 = new ProcessStartInfo();
                            astartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            astartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                            astartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo4.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo5.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo6.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo7.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo8.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo9.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo10.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo11.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo12.WindowStyle = ProcessWindowStyle.Hidden;
                            astartInfo.CreateNoWindow = true;
                            astartInfo2.CreateNoWindow = true;
                            astartInfo3.CreateNoWindow = true;
                            startInfo4.CreateNoWindow = true;
                            startInfo5.CreateNoWindow = true;
                            startInfo6.CreateNoWindow = true;
                            startInfo7.CreateNoWindow = true;
                            startInfo8.CreateNoWindow = true;
                            startInfo9.CreateNoWindow = true;
                            startInfo10.CreateNoWindow = true;
                            startInfo11.CreateNoWindow = true;
                            startInfo12.CreateNoWindow = true;
                            astartInfo.UseShellExecute = false;
                            astartInfo2.UseShellExecute = false;
                            astartInfo3.UseShellExecute = false;
                            startInfo4.UseShellExecute = false;
                            startInfo5.UseShellExecute = false;
                            startInfo6.UseShellExecute = false;
                            startInfo7.UseShellExecute = false;
                            startInfo8.UseShellExecute = false;
                            startInfo9.UseShellExecute = false;
                            startInfo10.UseShellExecute = false;
                            startInfo11.UseShellExecute = false;
                            startInfo11.UseShellExecute = false;
                            startInfo12.UseShellExecute = false;
                            astartInfo.RedirectStandardOutput = true;
                            astartInfo2.RedirectStandardOutput = true;
                            astartInfo3.RedirectStandardOutput = true;
                            startInfo4.RedirectStandardOutput = true;
                            startInfo5.RedirectStandardOutput = true;
                            startInfo6.RedirectStandardOutput = true;
                            startInfo7.RedirectStandardOutput = true;
                            startInfo8.RedirectStandardOutput = true;
                            startInfo9.RedirectStandardOutput = true;
                            startInfo10.RedirectStandardOutput = true;
                            startInfo11.RedirectStandardOutput = true;
                            startInfo12.RedirectStandardOutput = true;
                            astartInfo.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                            astartInfo2.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                            astartInfo3.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                            startInfo4.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                            startInfo5.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                            startInfo6.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                            startInfo7.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                            startInfo8.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                            startInfo9.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                            startInfo10.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                            startInfo11.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                            startInfo12.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                            astartInfo.Arguments = " shell getprop ro.product.model";
                            astartInfo2.Arguments = " shell getprop ro.product.manufacturer";
                            astartInfo3.Arguments = " shell getprop ro.build.version.release";
                            startInfo4.Arguments = " shell getprop ro.product.device";
                            startInfo5.Arguments = " shell getprop ro.product.brand";
                            startInfo6.Arguments = "shell getprop ro.build.id";
                            startInfo7.Arguments = "shell getprop ro.build.version.sdk";
                            startInfo8.Arguments = "shell getprop ro.build.version.codename";
                            startInfo9.Arguments = "shell getprop ro.build.version.all_codenames";
                            startInfo10.Arguments = "shell getprop ro.build.version.security_patch";
                            startInfo11.Arguments = "shell getprop ro.product.locale";
                            startInfo12.Arguments = " shell su -v ";
                            aprocess.StartInfo = astartInfo;
                            aprocess2.StartInfo = astartInfo2;
                            aprocess3.StartInfo = astartInfo3;
                            process4.StartInfo = startInfo4;
                            process5.StartInfo = startInfo5;
                            process6.StartInfo = startInfo6;
                            process7.StartInfo = startInfo7;
                            process8.StartInfo = startInfo8;
                            process9.StartInfo = startInfo9;
                            process10.StartInfo = startInfo10;
                            process11.StartInfo = startInfo11;
                            process12.StartInfo = startInfo12;
                            aprocess.Start();
                            aprocess2.Start();
                            aprocess3.Start();
                            process4.Start();
                            process5.Start();
                            process6.Start();
                            process7.Start();
                            process8.Start();
                            process9.Start();
                            process10.Start();
                            process11.Start();
                            process12.Start();
                            console.Text = console.Text + "Marka = " + aprocess2.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Model = " + aprocess.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Android Versiyon = " + aprocess3.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Kod Adı  = " + process4.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Üretici = " + process5.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Compilation Code = " + process6.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "SDK Numarası = " + process7.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Code Versiyon 1 = " + process8.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Code Versiyon 2 = " + process9.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Güvenlik Yaması Tarihi = " + process10.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Dil ve Ülke = " + process11.StandardOutput.ReadToEnd() + "\n";
                            if (process12.StandardOutput.ReadToEnd() == "")
                            {
                                console.Text = console.Text + "Root  = " + "Root Bulunamadı" + "\n";
                            }
                            else
                            {
                                console.Text = console.Text + "Root  = " + process12.StandardOutput.ReadToEnd() + "\n";

                            }

                        }


                        if (label8.Text == "")
                        {
                            pictureBox2.BackColor = Color.Red;
                            label10.Text = "Cihaz Bağlı Değil";
                            if (label10.Text == "Cihaz Bağlı Değil")
                            {
                                Process process4 = new Process();
                                ProcessStartInfo startInfo4 = new ProcessStartInfo();
                                startInfo4.WindowStyle = ProcessWindowStyle.Hidden;
                                startInfo4.CreateNoWindow = true;
                                startInfo4.UseShellExecute = false;
                                startInfo4.RedirectStandardOutput = true;
                                startInfo4.FileName = Application.StartupPath + @"\\bin\\fastboot.exe";
                                startInfo4.Arguments = "devices";
                                process.StartInfo = startInfo4;
                                process.Start();
                                label10.Text = process.StandardOutput.ReadToEnd();
                                console.Text = process.StandardOutput.ReadToEnd();
                                if (label10.Text == "")
                                {
                                    label10.Text = "Cihaz Bağlı Değil";
                                }
                                else
                                {
                                    pictureBox2.BackColor = Color.Aqua;
                                    if (pictureBox2.BackColor == Color.Aqua)
                                    {
                                        devicemode = 2;
                                    }

                                }

                            }
                        }
                        else
                        {
                            devicemode = 1;
                            pictureBox2.BackColor = Color.Blue;

                        }
                    }
                }

            }
        }
        private void ilkadim()
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = Application.StartupPath + @"\\bin\\vendorcountry.exe";
                startInfo.Arguments = "";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                FileStream dosyamız;
                StreamReader okuma;
                string yol = Application.StartupPath + Application.StartupPath + @"\\bin\\id.txt";

                dosyamız = new FileStream(yol, FileMode.Open, FileAccess.Read);
                okuma = new StreamReader(dosyamız);



                for (int i = 1; i < 1; i++)
                {
                    okuma.ReadLine();

                }
                string ok = okuma.ReadLine();
                // textBox2.Text = okuma.ReadLine();

                okuma.Close();
                writeLog(ok, Success);
                bootinfo();


            }
            catch
            {

                bootinfo();
            }

        }
        private void bootinfo()
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = Application.StartupPath + @"\\bin\\fastboot oem get-bootinfo.exe";
                startInfo.Arguments = "";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                FileStream dosyamız;
                StreamReader okuma;
                string yol = Application.StartupPath + @"\\bin\\info.txt";

                dosyamız = new FileStream(yol, FileMode.Open, FileAccess.Read);
                okuma = new StreamReader(dosyamız);



                for (int i = 1; i < 2; i++)
                {
                    okuma.ReadLine();

                }
                string ok = okuma.ReadLine();
                writeLog(ok, Success);

                okuma.Close();
                if (File.Exists(Application.StartupPath + @"\\bin\\info.txt") == true)
                {

                    File.Delete(Application.StartupPath + @"\\bin\\info.txt");
                    model();

                }
                else
                {
                    writeLog("Cihaz bağlı değildir.", Error);
                }
            }
            catch
            {

            }



        }
        private void model()
        {

            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = Application.StartupPath + @"\\bin\\get-product-model.exe";
                startInfo.Arguments = "";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                FileStream dosyamız;
                StreamReader okuma;
                string yol = Application.StartupPath + @"\\bin\\info.txt";

                dosyamız = new FileStream(yol, FileMode.Open, FileAccess.Read);
                okuma = new StreamReader(dosyamız);



                for (int i = 1; i < 2; i++)
                {
                    okuma.ReadLine();

                }
                string ok = okuma.ReadLine();
                writeLog(ok, Success);

                okuma.Close();
                if (File.Exists(Application.StartupPath + @"\\bin\\info.txt") == true)
                {

                    File.Delete(Application.StartupPath + @"\\bin\\info.txt");
                    psid();

                }
                else
                {
                    writeLog("Cihaz bağlı değildir.", Error);
                }
            }
            catch
            {


            }



        }
        private void psid()
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = Application.StartupPath + @"\\bin\\get-psid.exe";
                startInfo.Arguments = "";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                FileStream dosyamız;
                StreamReader okuma;
                string yol = Application.StartupPath + @"\\bin\\info.txt";

                dosyamız = new FileStream(yol, FileMode.Open, FileAccess.Read);
                okuma = new StreamReader(dosyamız);



                for (int i = 1; i < 2; i++)
                {
                    okuma.ReadLine();

                }
                string ok = okuma.ReadLine();
                writeLog(ok, Success);

                okuma.Close();
                if (File.Exists(Application.StartupPath + @"\\bin\\info.txt") == true)
                {

                    File.Delete(Application.StartupPath + @"\\bin\\info.txt");
                    read3();

                }
                else
                {
                    writeLog("Cihaz bağlı değildir.", Error);
                }
            }
            catch
            {

            }

        }
        private void read3()
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = Application.StartupPath + @"\\bin\\get-psid.exe";
                startInfo.Arguments = "";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                FileStream dosyamız;
                StreamReader okuma;
                string yol = Application.StartupPath + @"\\bin\\info.txt";

                dosyamız = new FileStream(yol, FileMode.Open, FileAccess.Read);
                okuma = new StreamReader(dosyamız);



                for (int i = 1; i < 3; i++)
                {
                    okuma.ReadLine();

                }
                string ok = okuma.ReadLine();
                writeLog(ok, Success);

                okuma.Close();
                if (File.Exists(Application.StartupPath + @"\\bin\\info.txt") == true)
                {

                    File.Delete(Application.StartupPath + @"\\bin\\info.txt");
                    read4();

                }
                else
                {
                    writeLog("Cihaz bağlı değildir.", Error);
                }
            }
            catch
            {

            }
        }



        private void read4()
        {
            {
                try
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = Application.StartupPath + @"\\bin\\get-psid.exe";
                    startInfo.Arguments = "";
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    FileStream dosyamız;
                    StreamReader okuma;
                    string yol = Application.StartupPath + @"\\bin\\info.txt";

                    dosyamız = new FileStream(yol, FileMode.Open, FileAccess.Read);
                    okuma = new StreamReader(dosyamız);



                    for (int i = 1; i < 4; i++)
                    {
                        okuma.ReadLine();

                    }
                    string ok = okuma.ReadLine();
                    writeLog(ok, Success);

                    okuma.Close();
                    if (File.Exists(Application.StartupPath + @"\\bin\\info.txt") == true)
                    {

                        File.Delete(Application.StartupPath + @"\\bin\\info.txt");
                        read5();

                    }
                    else
                    {
                        writeLog("Cihaz bağlı değildir.", Error);
                    }
                }
                catch
                {

                }

            }
        }
        private void read5()
        {
            {
                try
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = Application.StartupPath + @"\\bin\\get-psid.exe";
                    startInfo.Arguments = "";
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    FileStream dosyamız;
                    StreamReader okuma;
                    string yol = Application.StartupPath + @"\\bin\\info.txt";

                    dosyamız = new FileStream(yol, FileMode.Open, FileAccess.Read);
                    okuma = new StreamReader(dosyamız);



                    for (int i = 1; i < 5; i++)
                    {
                        okuma.ReadLine();

                    }
                    string ok = okuma.ReadLine();
                    writeLog(ok, Success);

                    okuma.Close();
                    if (File.Exists(Application.StartupPath + @"\\bin\\info.txt") == true)
                    {

                        File.Delete(Application.StartupPath + @"\\bin\\info.txt");
                        rescue();

                    }
                    else
                    {
                        writeLog("Cihaz bağlı değildir.", Warning);
                    }
                }
                catch
                {

                }

            }
        }







        //
        private void rescue()
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = Application.StartupPath + @"\\bin\\rescue.exe";
                startInfo.Arguments = "";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                FileStream dosyamız;
                StreamReader okuma;
                string yol = Application.StartupPath + @"\\bin\\info.txt";

                dosyamız = new FileStream(yol, FileMode.Open, FileAccess.Read);
                okuma = new StreamReader(dosyamız);



                for (int i = 1; i < 2; i++)
                {
                    okuma.ReadLine();

                }
                string ok = okuma.ReadLine();
                writeLog(ok, Success);

                okuma.Close();
                if (File.Exists(Application.StartupPath + @"\\bin\\info.txt") == true)
                {

                    File.Delete(Application.StartupPath + @"\\bin\\info.txt");
                    rescue_phoneinfo();
                    ;

                }
                else
                {
                    writeLog("Cihaz bağlı değildir.", Error);
                }
            }
            catch
            {

            }

        }
        private void rescue_phoneinfo()
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = Application.StartupPath + @"\\bin\\rescue_phoneinfo.exe";
                startInfo.Arguments = "";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                FileStream dosyamız;
                StreamReader okuma;
                string yol = Application.StartupPath + @"\\bin\\info.txt";

                dosyamız = new FileStream(yol, FileMode.Open, FileAccess.Read);
                okuma = new StreamReader(dosyamız);



                for (int i = 1; i < 2; i++)
                {
                    okuma.ReadLine();

                }
                string ok = okuma.ReadLine();
                writeLog(ok, Success);

                okuma.Close();
                if (File.Exists(Application.StartupPath + @"\\bin\\info.txt") == true)
                {

                    File.Delete(Application.StartupPath + @"\\bin\\info.txt");
                    writeLog("All Done By GSMTurkey Tool", Warning);
                    Process process2 = new Process();
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo2.CreateNoWindow = true;
                    startInfo2.UseShellExecute = false;
                    startInfo2.RedirectStandardOutput = true;
                    startInfo2.FileName = Application.StartupPath + @"\\bin\\adb2.exe";
                    startInfo2.Arguments = "reboot bootloader";
                    process2.StartInfo = startInfo2;
                    process2.Start();
                }
                else
                {
                    writeLog("Cihaz bağlı değildir.", Error);
                }
            }
            catch
            {

            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                simpleButton9.Appearance.BackColor = Color.Red;

            }
            else
            {
                simpleButton9.Appearance.BackColor = Color.Green;

            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                button_2.Appearance.BackColor = Color.Red;
            }
            else
            {
                button_2.Appearance.BackColor = Color.Green;

            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                button_3.Appearance.BackColor = Color.Red;
            }
            else
            {
                button_3.Appearance.BackColor = Color.Green;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                button_4.Appearance.BackColor = Color.Red;
            }
            else
            {
                button_4.Appearance.BackColor = Color.Green;

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                button_5.Appearance.BackColor = Color.Red;
            }
            else
            {
                button_5.Appearance.BackColor = Color.Green;

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                button_6.Appearance.BackColor = Color.Red;
            }
            else
            {
                button_6.Appearance.BackColor = Color.Green;

            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.gsmturkey.net/");
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Process.Start("https://huaweiadvices.com/install-adb-fastboot-drivers-windows-pc/");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            devicechecker();
            writeLog("Cihaz fastboot moduna alınıyor...", Error);
            Process process2 = new Process();
            ProcessStartInfo startInfo2 = new ProcessStartInfo();
            startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo2.CreateNoWindow = true;
            startInfo2.UseShellExecute = false;
            startInfo2.RedirectStandardOutput = true;
            startInfo2.FileName = Application.StartupPath + @"\\bin\\fastboot.exe";
            startInfo2.Arguments = "oem lock";
            process2.StartInfo = startInfo2;
            process2.Start();
            writeLog("İşlev Başarılı, Lütfen Manuel kontrol yapınız.", Warning);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            devicechecker();
            writeLog("Cihaz fastboot moduna alınıyor...", Warning);
            Process process2 = new Process();
            ProcessStartInfo startInfo2 = new ProcessStartInfo();
            startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo2.CreateNoWindow = true;
            startInfo2.UseShellExecute = false;
            startInfo2.RedirectStandardOutput = true;
            startInfo2.FileName = Application.StartupPath + @"\\bin\\fastboot.exe";
            startInfo2.Arguments = "oem unlock-go";
            process2.StartInfo = startInfo2;
            process2.Start();
            writeLog("İşlev Başarılı, Lütfen Manuel kontrol yapınız.", Warning);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            devicechecker();
            if (devicemode == 1)
            {
                writeLog("Cihaz fastboot moduna alınıyor...", Warning);
                Process process2 = new Process();
                ProcessStartInfo startInfo2 = new ProcessStartInfo();
                startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo2.CreateNoWindow = true;
                startInfo2.UseShellExecute = false;
                startInfo2.RedirectStandardOutput = true;
                startInfo2.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                startInfo2.Arguments = "reboot bootloader";
                process2.StartInfo = startInfo2;
                process2.Start();
            }
            if (devicemode == 2)
            {
                writeLog("Cihaz fastboot moduna alınıyor...", Warning);
                Process process2 = new Process();
                ProcessStartInfo startInfo2 = new ProcessStartInfo();
                startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo2.CreateNoWindow = true;
                startInfo2.UseShellExecute = false;
                startInfo2.RedirectStandardOutput = true;
                startInfo2.FileName = Application.StartupPath + @"\\bin\\fastboot.exe";
                startInfo2.Arguments = "reboot-bootloader";
                process2.StartInfo = startInfo2;
                process2.Start();
            }

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            devicechecker();
            if (devicemode == 1)
            {
                writeLog("Cihaz Normal Şekilde Açılıyor...", Warning);
                Process process2 = new Process();
                ProcessStartInfo startInfo2 = new ProcessStartInfo();
                startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo2.CreateNoWindow = true;
                startInfo2.UseShellExecute = false;
                startInfo2.RedirectStandardOutput = true;
                startInfo2.FileName = Application.StartupPath + @"\\bin\\adb.exe";
                startInfo2.Arguments = "reboot";
                process2.StartInfo = startInfo2;
                process2.Start();
            }
            if (devicemode == 2)
            {
                writeLog("Cihaz Normal Şekilde Açılıyor...", Warning);
                Process process2 = new Process();
                ProcessStartInfo startInfo2 = new ProcessStartInfo();
                startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo2.CreateNoWindow = true;
                startInfo2.UseShellExecute = false;
                startInfo2.RedirectStandardOutput = true;
                startInfo2.FileName = Application.StartupPath + @"\\bin\\fastboot.exe";
                startInfo2.Arguments = "reboot";
                process2.StartInfo = startInfo2;
                process2.Start();
            }
            else
            {
                writeLog("Cihaz bağlı değildir.", Error);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                simpleButton1.Text = "Bilgileri Oku";
                simpleButton3.Text = "OEM Kilidi Kapat";
                simpleButton2.Text = "OEM Kilidi Aç";
                simpleButton4.Text = "Fastboot Geçiş";
                simpleButton5.Text = "Cihazı Normal Aç";
                simpleButton6.Text = "Driver Yükle";
                simpleButton7.Text = "Destek";
                checkBox1.Text = "Activate English Language Support (UnChecked)";
            }
            else
            {
                simpleButton1.Text = "Read Info";
                simpleButton3.Text = "OEM Lock";
                simpleButton2.Text = "OEM UnLock";
                simpleButton4.Text = "Reboot Bootloader";
                simpleButton5.Text = "Reboot System";
                simpleButton6.Text = "Install Driver";
                simpleButton7.Text = "Support";
                checkBox1.Text = "Türkçe Dil Desteğini Aktifleştir";
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }



        void writeLog(string text, int type)
        {
            string color = "#4169e1";
            DateTime date = DateTime.Now;
            if (type == Success)
            {
                color = "#007f00";
            }
            else if (type == Error)
            {
                color = "#e50000";
            }
            else if (type == Warning)
            {
                color = "#cc8400";
            }

            if (log.InvokeRequired)
            {
                log.Invoke(new MethodInvoker(delegate ()
                {
                    var index = log.Rows.Add();
                    log.Rows[index].DefaultCellStyle.ForeColor = ColorTranslator.FromHtml(color);
                    log.Rows[index].Cells[0].Value = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                    log.Rows[index].Cells[1].Value = type;
                    log.Rows[index].Cells[2].Value = date.ToString("dd.MM.yyyy HH:mm:ss");
                    log.Rows[index].Cells[3].Value = text;
                }));
            }
            else
            {
                var index = log.Rows.Add();
                log.Rows[index].DefaultCellStyle.ForeColor = ColorTranslator.FromHtml(color);
                log.Rows[index].Cells[0].Value = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                log.Rows[index].Cells[1].Value = type;
                log.Rows[index].Cells[2].Value = date.ToString("dd.MM.yyyy HH:mm:ss");
                log.Rows[index].Cells[3].Value = text;
            }
            log.Sort(unixtime, ListSortDirection.Descending);
            System.Threading.Thread.Sleep(1000);
        }
        private void log_disableSelection(Object sender, EventArgs e)
        {
            log.ClearSelection();
        }
        private void parts_disableSelection(Object sender, EventArgs e)
        {

        }

        private void parts_columnHeaderClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}



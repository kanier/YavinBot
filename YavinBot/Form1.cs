using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;


namespace YavinBot
{
    public partial class Form1 : MetroForm
    {
        BackgroundWorker bw;
        public Form1()
        {
            InitializeComponent();
            this.bw = new BackgroundWorker();
            this.bw.DoWork += bw_DoWork;
        }
        async void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            var key = e.Argument as String; // получаем ключ из аргументов

            try
            {
                var Bot = new Telegram.Bot.TelegramBotClient(key); // инициализируем API
                await Bot.SetWebhookAsync(""); // Обязательно! убираем старую привязку к вебхуку для бота
                
                Bot.OnUpdate += async (object su, Telegram.Bot.Args.UpdateEventArgs evu) =>
                {
                    if (evu.Update.CallbackQuery != null || evu.Update.InlineQuery != null) return; // в этом блоке нам келлбэки и инлайны не нужны
                    var update = evu.Update;
                    var message = update.Message;
                    
                    string txt = Properties.Settings.Default.solo;
                    if (message == null) return;
                    if (message.Type == Telegram.Bot.Types.Enums.MessageType.TextMessage)
                    {
                    var username = message.From.Username;
                    var name = message.From.FirstName;
                        var surname = message.From.LastName;
                        // Тестовый кусок. Начало.
                        if (message.Text == "/reroll" || message.Text == "/reroll@YavinIV_rollbot")
                        {
                            if (username.Equals("kanier")|| username.Equals("batmanbilochka") || username.Equals("SanguisVlad") || username.Equals("tim_kadyrov") || username.Equals("Maximych4PDA") || username.Equals("Elixir4pda") || username.Equals("USSRchild") || username.Equals("Granula44"))
                            {
                                //List<string> lstL = new List<string>();
                                //string lstall = System.IO.File.ReadAllText("solo.txt");
                                //string newlst = lstall.Replace("@", "");
                                //string llsall = string.Join("\r\n", lstL.ToArray());///
                                //await Bot.SendTextMessageAsync(message.Chat.Id, name+" "+surname+", ты пиздат!", replyToMessageId: message.MessageId);
                                List<string> lst = new List<string>();

                                Random rand = new Random();

                                var inx = System.IO.File.ReadAllLines("solo.txt");

                                string[] str = new string[1]; // здесь будут храниться n случаные неповторяющиеся строки из inx

                                int k;

                                for (int i = 0; i < str.Length; i++)
                                {

                                    while (true)
                                    {

                                        k = rand.Next(inx.Length);

                                        if (!lst.Any(x => x.Equals(inx[k])))
                                        {

                                            lst.Add(inx[k]);

                                            str[i] = inx[k];

                                            break;

                                        }

                                    }

                                }

                                string lls = string.Join("\r\n", lst.ToArray());
                                Properties.Settings.Default.short_solo = lls;
                                Properties.Settings.Default.solo = "Для закрытия следующей Ямы-0, Колесом Фортуны избран " + lls + " ! Здесь зрители аплодируют. Аплодируют, аплодируют, аплодируют. Кончили аплодировать.";
                                Properties.Settings.Default.Save();
                                await Bot.SendTextMessageAsync(message.Chat.Id, "В этот Фортуна избрала "+lls, replyToMessageId: message.MessageId);
                                //list_out.Text = Properties.Settings.Default.solo;
                            }
                            else
                            {
                                await Bot.SendTextMessageAsync(message.Chat.Id, "Уважаемый(ая) "+name+" , Вам запрещено использование этой команды. Извините.", replyToMessageId: message.MessageId);
                            }
                            
                        }
                        
                        // Тестовый кусок. Конец.
                        if (message.Text == "/sololist" || message.Text == "/sololist@YavinIV_rollbot")
                        {
                            List<string> lstL = new List<string>();
                            string lstall = System.IO.File.ReadAllText("solo.txt");
                            string newlst = lstall.Replace("@","");
                            //string llsall = string.Join("\r\n", lstL.ToArray());///
                            await Bot.SendTextMessageAsync(message.Chat.Id, newlst, replyToMessageId: message.MessageId);

                        }
                        if (message.Text == "/solo@YavinIV_rollbot" || message.Text == "/solo")

                        {
                            if (username.Equals("kanier") || username.Equals("batmanbilochka") || username.Equals("SanguisVlad") || username.Equals("tim_kadyrov") || username.Equals("Maximych4PDA") || username.Equals("Elixir4pda") || username.Equals("USSRchild") || username.Equals("Granula44"))
                            {
                                // в ответ на команду выводим сообщение
                                await Bot.SendTextMessageAsync(message.Chat.Id, txt, replyToMessageId: message.MessageId);
                            }
                            else
                            {
                                string ntxt = Properties.Settings.Default.short_solo;
                                string wotxt = ntxt.Replace("@", "");
                                await Bot.SendTextMessageAsync(message.Chat.Id, "Для закрытия следующей Ямы-0, Колесом Фортуны избран " + wotxt + " !Здесь зрители аплодируют. Аплодируют, аплодируют, аплодируют.Кончили аплодировать.", replyToMessageId: message.MessageId);
                            }
                            
                        }

                        if (message.Text == "/nakatim@YavinIV_rollbot" || message.Text == "/nakatim" || message.Text == "Накатим!" || message.Text == "🍷" || message.Text == "Бармен, Накатим!" || message.Text == "Рря!")
                        {
                            List<string> lstT = new List<string>();
                            Random randT = new Random();
                            var inxT = System.IO.File.ReadAllLines("tost.txt");
                            string[] str = new string[1]; // здесь будут храниться n случаные неповторяющиеся строки из inxT
                            int k;

                            for (int i = 0; i < str.Length; i++)
                            {

                                while (true)
                                {

                                    k = randT.Next(inxT.Length);

                                    if (!lstT.Any(x => x.Equals(inxT[k])))
                                    {

                                        lstT.Add(inxT[k]);

                                        str[i] = inxT[k];

                                        break;

                                    }

                                }

                            }

                            string lls = string.Join("\r\n", lstT.ToArray());
                            
                            await Bot.SendTextMessageAsync(message.Chat.Id, lls, replyToMessageId: message.MessageId);
                        }
                        if (message.Text == "/aat@YavinIV_rollbot" || message.Text == "/aat" )
                        {
                            List<string> lstR = new List<string>();


                            var inxR = System.IO.File.ReadAllLines("aat.txt");


                            string llsR = string.Join("\r\n", inxR.ToArray());


                            await Bot.SendTextMessageAsync(message.Chat.Id, llsR, replyToMessageId: message.MessageId);
                        }
                        if (message.Text == "/rancor@YavinIV_rollbot" || message.Text == "/rancor")
                        {
                            List<string> lstR = new List<string>();


                            var inxR = System.IO.File.ReadAllLines("rancor.txt");


                            string llsR = string.Join("\r\n", inxR.ToArray());


                            await Bot.SendTextMessageAsync(message.Chat.Id, llsR, replyToMessageId: message.MessageId);
                        }
                    }

                };

                // запускаем прием обновлений
                Bot.StartReceiving();
            }
            catch (Telegram.Bot.Exceptions.ApiRequestException ex)
            {
                Console.WriteLine(ex.Message); // если ключ не подошел - пишем об этом в консоль отладки
            }

        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.bw.RunWorkerAsync("399222874:AAFEZ3Q9nMq1kwkod9l4VMMaeRHX3uQ_xEc");
            lbl_status.ForeColor = System.Drawing.Color.Green;
            lbl_status.Text = "Бот запущен...";
            list_out.SelectionAlignment = HorizontalAlignment.Center;
            list_out.Text = Properties.Settings.Default.solo;
        }

        private void BtnRun_Click_1(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();

            Random rand = new Random();

            var inx = System.IO.File.ReadAllLines("solo.txt");

            string[] str = new string[1]; // здесь будут храниться n случаные неповторяющиеся строки из inx

            int k;

            for (int i = 0; i < str.Length; i++)
            {

                while (true)
                {

                    k = rand.Next(inx.Length);

                    if (!lst.Any(x => x.Equals(inx[k])))
                    {

                        lst.Add(inx[k]);

                        str[i] = inx[k];

                        break;

                    }

                }

            }

            string lls = string.Join("\r\n", lst.ToArray());
            Properties.Settings.Default.short_solo = lls;
            Properties.Settings.Default.solo = "Для закрытия следующей Ямы-0, Колесом Фортуны избран " + lls + " ! Здесь зрители аплодируют. Аплодируют, аплодируют, аплодируют. Кончили аплодировать.";
            Properties.Settings.Default.Save();
            list_out.Text = Properties.Settings.Default.solo;
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

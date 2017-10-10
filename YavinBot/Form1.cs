using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using System.IO;

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

                //Bot.SendTextMessageAsync(message.Chat.Id, "Проверка", replyToMessageId: message.MessageId);

                // Callback'и от кнопок
                //Bot.OnCallbackQuery += async (object sc, Telegram.Bot.Args.CallbackQueryEventArgs ev) =>
                //{
                //    var message = ev.CallbackQuery.Message;
                //    if (ev.CallbackQuery.Data == "callback1")
                //    {
                //        await Bot.AnswerCallbackQueryAsync(ev.CallbackQuery.Id, "You hav choosen " + ev.CallbackQuery.Data, true);
                //    }
                //    else
                //    if (ev.CallbackQuery.Data == "callback2")
                //    {
                //        await Bot.SendTextMessageAsync(message.Chat.Id, "тест", replyToMessageId: message.MessageId);
                //        await Bot.AnswerCallbackQueryAsync(ev.CallbackQuery.Id); // отсылаем пустое, чтобы убрать "частики" на кнопке
                //    }
                //};

                Bot.OnUpdate += async (object su, Telegram.Bot.Args.UpdateEventArgs evu) =>
                {
                    if (evu.Update.CallbackQuery != null || evu.Update.InlineQuery != null) return; // в этом блоке нам келлбэки и инлайны не нужны
                    //var txt = list_out.Text;
                    var update = evu.Update;
                    var message = update.Message;
                    string txt = Properties.Settings.Default.solo;
                    if (message == null) return;
                    if (message.Type == Telegram.Bot.Types.Enums.MessageType.TextMessage)
                    {
                        if (message.Text == "/solo@YavinIV_rollbot" || message.Text == "/solo")
                        {
                            // в ответ на команду /saysomething выводим сообщение
                            await Bot.SendTextMessageAsync(message.Chat.Id, txt, replyToMessageId: message.MessageId);
                        }
                        if (message.Text == "/nakatim@YavinIV_rollbot" || message.Text == "/nakatim" || message.Text == "Накатим!" || message.Text == "🍷" || message.Text == "Бармен, Накатим!")
                        {
                            List<string> lstT = new List<string>();

                            Random randT = new Random();

                            var inxT = File.ReadAllLines("tost.txt");

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
                            // в ответ на команду /saysomething выводим сообщение
                            await Bot.SendTextMessageAsync(message.Chat.Id, lls, replyToMessageId: message.MessageId);
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

            var inx = File.ReadAllLines("solo.txt");

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

            //string fulltxt = Properties.Settings.Default.dateW;
            //fulltxt = fulltxt + lls;
            //Properties.Settings.Default.solo = fulltxt;
            Properties.Settings.Default.solo = "Для закрытия следующей Ямы-0, Колесом Фортуны избран " + lls + " ! Здесь зрители аплодируют. Аплодируют, аплодируют, аплодируют. Кончили аплодировать.";
            Properties.Settings.Default.Save();
            list_out.Text = Properties.Settings.Default.solo;
        }
    }
}

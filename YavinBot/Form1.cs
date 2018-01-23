using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telegram.Bot.Types;
using System.Management;

namespace YavinBot
{
    public partial class Form1 : Form
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

                //TEST

                try
                {

                    Bot.OnUpdate += async (object su, Telegram.Bot.Args.UpdateEventArgs evu) =>
                    {
                        if (evu.Update.CallbackQuery != null || evu.Update.InlineQuery != null) return; // в этом блоке нам келлбэки и инлайны не нужны
                        var update = evu.Update;
                        var message = update.Message;

                        string txt = Properties.Settings.Default.solo;
                        if (message == null) return;

                        if (message.Type == Telegram.Bot.Types.Enums.MessageType.TextMessage)
                        {
                            
                                var chtid = message.Chat.Id;
                                var username = message.From.Username;
                                var name = message.From.FirstName;
                                var surname = message.From.LastName;
                                //var stream = System.IO.File.Open("GP.xlsx", FileMode.Open);
                                FileToSend stick = new FileToSend("CAADAgADjAAD2kJgEdHmJbf9LcNAAg");
                                FileToSend kickstick = new FileToSend("CAADAgADFwADCpgGDPT5dlQ90N3vAg");
                                FileToSend gogo = new FileToSend("CAADAgADIgADCpgGDP2DujSOYxb2Ag");
                                FileToSend stb_1 = new FileToSend("CAADAgADKAADCpgGDAlPwj3jog11Ag");
                                FileToSend pipi = new FileToSend("bolt.jpg");
                                string offlist = System.IO.File.ReadAllText("offlist.txt");
                                //string guildlist = System.IO.File.ReadAllText("guildlist.txt");
                            


                try
                            {

                            if (message.Text.Equals("Запрос 900"))
                                {
                                    string f1text = System.IO.File.ReadAllText("f1.txt");
                                    var stream1 = System.IO.File.Open("STB.jpg", FileMode.Open);
                                    FileToSend pipi1 = new FileToSend("STB.jpg",stream1);
                                    pipi1.Content = stream1;
                                    pipi1.Filename = "STB.jpg";
                                    await Bot.SendPhotoAsync(message.Chat.Id, photo: pipi1, caption: f1text);
                                    return;
                                }
                            //ДЛЯ ЕВЫ
                            if (message.Text.Contains("Ева, "))
                                {
                                    string inmess = message.Text.ToLower();
                                //TEST CHAT ID
                                if (inmess.Contains("пришло время"))
                                    {
                                        await Bot.SendStickerAsync(message.Chat.Id, kickstick);
                                        return;
                                    }


                                    if (inmess.Contains("chatid"))
                                    {
                                        if (username.Equals("kanier"))
                                        {
                                            await Bot.SendTextMessageAsync(message.Chat.Id, chtid.ToString());
                                            return;
                                        }
                                        return;
                                    }

                                //TEST MESSAGE TO OTHER CHAT
                                if (inmess.Contains("отправь") && offlist.Contains(username))
                                    {
                                        if (inmess.Contains("стикер кик"))
                                        {
                                            await Bot.SendStickerAsync("-1001119850321", kickstick);
                                            return;
                                        }
                                    ////Properties.Settings.Default.buffer = inmess;
                                    //string sendinmess = inmess.Replace("Ева, ", "");
                                    //Properties.Settings.Default.buffer = sendinmess;
                                    //Properties.Settings.Default.Save();
                                    //string smess = Properties.Settings.Default.buffer; 
                                    await Bot.SendTextMessageAsync("-1001119850321", message.Text.Replace("Ева, отправь ", ""));
                                        return;

                                    }
                                 if (inmess.Contains("гого")&& offlist.Contains(username))
                                    {
                                        try
                                        {
                                            //var stream = System.IO.File.Open("vsenatb.mp4", FileMode.Open);
                                            //FileToSend fts = new FileToSend();
                                            
                                            //   // Stream stream = null;
                                            //    fts.Content = stream;
                                            //    fts.Filename = "Все на ТБ!!!";
                                                
                                            
                                            //await Bot.SendDocumentAsync("-1001119850321", fts, "Все на ТБ!!!");
                                            await Bot.SendStickerAsync("-1001119850321", gogo);
                                            await Bot.SendStickerAsync("-1001121566331 ", gogo);
                                            //            //await Bot.SendDocumentAsync(message.Chat.Id, new FileToSend("GP.xlsx"));
                                            return;
                                        }
                                        catch (Exception ex)
                                        {
                                            System.IO.File.WriteAllText("errorall.txt", ex.Message);
                                            //await Bot.SendTextMessageAsync(message.Chat.Id, "Что-то не так");
                                            return;
                                        
                                        }


                                    }
                                    if (inmess.Contains("привет") || inmess.Contains("как дела") || inmess.Contains("здрав"))
                                    {
                                        await Bot.SendTextMessageAsync(message.Chat.Id, "Привет, " + name + "." + "\r\n" + "Что ты хочешь знать?" + "\r\n" + "Я могу напомнить тебе правила Ямы или ААТ, показать список солистов или памятку по ТБ. Могу напомнить, кто закрывает соло следующую Яму-0. И многое другое ;) Достаточно обратиться ко мне по имени. К примеру: \"Ева, кто закрывает соло?\"", replyToMessageId: message.MessageId);
                                        return;
                                    }
                                    if (inmess.Contains("соло") || inmess.Contains("закрывает"))

                                    {
                                        if (inmess.Contains("хан"))
                                        {
                                            await Bot.SendTextMessageAsync(message.Chat.Id, "Что-то слишком много Ханов развелось...");
                                            return;
                                        }
                                    //if (username.Equals("kanier") || username.Equals("batmanbilochka") || username.Equals("SanguisVlad") || username.Equals("tim_kadyrov") || username.Equals("Maximych4PDA") || username.Equals("Elixir4pda") || username.Equals("USSRchild") || username.Equals("Granula44"))
                                    if (offlist.Contains(username))
                                        {
                                        // в ответ на команду выводим сообщение
                                        await Bot.SendTextMessageAsync(message.Chat.Id, txt);
                                            return;
                                        }
                                        else
                                        {
                                            string ntxt = Properties.Settings.Default.short_solo;
                                            string wotxt = ntxt.Replace("@", "");
                                            await Bot.SendTextMessageAsync(message.Chat.Id, "Для закрытия следующей Ямы-0, Колесом Фортуны избран " + wotxt + " !");
                                            return;
                                        }
                                    }

                                    if (inmess.Contains("накати") || inmess.Contains("рря") || inmess.Contains("тост"))
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

                                        await Bot.SendTextMessageAsync(message.Chat.Id, lls);
                                        return;
                                    }

                                    if (inmess.Contains("стб"))
                                    {
                                        //if (inmess.Contains("фаза"))
                                        //{
                                            string f1text = System.IO.File.ReadAllText("f1.txt");
                                            string f2text = System.IO.File.ReadAllText("f2.txt");
                                            string f3text = System.IO.File.ReadAllText("f3.txt");
                                            string f4text = System.IO.File.ReadAllText("f4.txt");
                                            string f5text = System.IO.File.ReadAllText("f5.txt");
                                            string f6text = System.IO.File.ReadAllText("f6.txt");
                                            var stream1 = System.IO.File.Open("STB.jpg", FileMode.Open);
                                            FileToSend pipi1 = new FileToSend("STB.jpg", stream1)
                                            {
                                            Content = stream1,
                                            Filename = "STB.jpg"
                                            };

                                        if (inmess.Contains("1"))
                                            {
                                            //await Bot.SendStickerAsync(message.Chat.Id, stb_1);
                                            //
                                            //return;
                                            await Bot.SendPhotoAsync(message.Chat.Id, photo: pipi1);
                                            await Bot.SendTextMessageAsync(message.Chat.Id, f1text);
                                            return;

                                        }

                                            if (inmess.Contains("2"))
                                            {
                                            //
                                            //return;
                                            await Bot.SendPhotoAsync(message.Chat.Id, photo: pipi1);
                                            await Bot.SendTextMessageAsync(message.Chat.Id, f2text);
                                            return;
                                        }

                                            if (inmess.Contains("3"))
                                            {
                                            await Bot.SendPhotoAsync(message.Chat.Id, photo: pipi1);
                                            await Bot.SendTextMessageAsync(message.Chat.Id, f3text);
                                                return;
                                            }

                                            if (inmess.Contains("4"))
                                            {
                                            await Bot.SendPhotoAsync(message.Chat.Id, photo: pipi1);
                                            await Bot.SendTextMessageAsync(message.Chat.Id, f4text);
                                                return;
                                            }

                                            if (inmess.Contains("5"))
                                            {
                                            await Bot.SendPhotoAsync(message.Chat.Id, photo: pipi1);
                                            await Bot.SendTextMessageAsync(message.Chat.Id, f5text);
                                                return;
                                            }

                                            if (inmess.Contains("6"))
                                            {
                                            await Bot.SendPhotoAsync(message.Chat.Id, photo: pipi1);
                                            await Bot.SendTextMessageAsync(message.Chat.Id, f6text);
                                                return;
                                            }
                                        //}


                                        string tbfile = System.IO.File.ReadAllText("tb.txt");
                                        await Bot.SendTextMessageAsync(message.Chat.Id, tbfile);
                                        return;
                                    }
                                    if (inmess.Contains("ттб"))
                                    {
                                        await Bot.SendTextMessageAsync(message.Chat.Id, "К сожалению, мне пока ничего об этом не известно. Посмотрим, что там нахерачили ЕА.", replyToMessageId: message.MessageId);
                                        return;

                                    }
                                    if (inmess.Contains("прости") || inmess.Contains("извин"))
                                    {
                                        await Bot.SendTextMessageAsync(message.Chat.Id, "Ничего страшного! Но я это запомню...", replyToMessageId: message.MessageId);
                                        return;
                                    }
                                    if (inmess.Contains("ям") || inmess.Contains("ранкор"))
                                    {
                                        List<string> lstR = new List<string>();
                                        var inxR = System.IO.File.ReadAllLines("rancor.txt");
                                        string llsR = string.Join("\r\n", inxR.ToArray());
                                        await Bot.SendTextMessageAsync(message.Chat.Id, "Я напомню тебе правила)))" + "\r\n" + llsR);
                                        return;
                                    }
                                    if (inmess.Contains("чудо") || inmess.Contains("хорошая") || inmess.Contains("умни") || inmess.Contains("умна") || inmess.Contains("крас"))
                                    {
                                        await Bot.SendTextMessageAsync(message.Chat.Id, "Спасибо, мне очень приятно!");
                                        return;
                                    }
                                    if (inmess.Contains("список"))
                                    {
                                        try
                                        {
                                            List<string> lstL = new List<string>();
                                            string lstall = System.IO.File.ReadAllText("solo.txt");
                                            string newlst = lstall.Replace("@", "");
                                            await Bot.SendTextMessageAsync(message.Chat.Id, newlst, replyToMessageId: message.MessageId);
                                            return;
                                        }
                                        catch
                                        {
                                            await Bot.SendTextMessageAsync(message.Chat.Id, "Список солистов пуст. Надо бы обновить.");
                                            return;
                                        }
                                    }
                                //if (inmess.Contains("gp"))
                                //{
                                //    if (offlist.Contains(username))
                                //    {
                                //        try
                                //        {
                                //            FileToSend fts = new FileToSend();
                                //            fts.Content = stream;
                                //            fts.Filename = "GP.xlsx";

                                //            await Bot.SendDocumentAsync(message.Chat.Id, fts, "Вот файл");
                                //            //await Bot.SendDocumentAsync(message.Chat.Id, new FileToSend("GP.xlsx"));
                                //            return;
                                //        }
                                //        catch
                                //        {
                                //            await Bot.SendTextMessageAsync(message.Chat.Id, "Что-то пошло не так :(");
                                //            //await Bot.SendDocumentAsync(message.Chat.Id, new FileToSend("GP.xlsx"));
                                //            return;
                                //        }
                                //    }
                                //}
                                if (inmess.Contains("аат") || inmess.Contains("танк"))
                                    {
                                        List<string> lstR = new List<string>();
                                        var inxR = System.IO.File.ReadAllLines("aat.txt");
                                        string llsR = string.Join("\r\n", inxR.ToArray());
                                        await Bot.SendTextMessageAsync(message.Chat.Id, llsR, replyToMessageId: message.MessageId);
                                        return;
                                    }

                                if (inmess.Contains("думаешь"))
                                    {

                                        await Bot.SendTextMessageAsync(message.Chat.Id, name + ", у меня просто нет слов.", replyToMessageId: message.MessageId);
                                        return;
                                    }

                                if (inmess.Contains("выбери нового солиста"))
                                    {
                                        if (offlist.Contains(username))
                                        {

                                        //var checksolo = System.IO.File.ReadAllLines("solo.txt");
                                        //if (checksolo.Length == 0)
                                        //{
                                        //    MessageBox.Show("Файл пуст!");
                                        //}
                                        string lastsolo = Properties.Settings.Default.short_solo;
                                            var soloL = System.IO.File.ReadAllText("solo.txt");
                                            var soloX = soloL.Replace(lastsolo, "");
                                        //var soloF = soloX.Replace("\n\n", "\n");
                                        //var lines = System.IO.File.ReadAllLines("solo.txt");
                                        //string[] linesX = lines.re
                                        //System.IO.File.WriteAllLines("solo.txt", lines);
                                        //MessageBox.Show(lastsolo);
                                        //MessageBox.Show(soloF);
                                        System.IO.File.WriteAllText("solo.txt", soloX);

                                            string fileName = "solo.txt";
                                            string outputFileName = "solotemp.txt";
                                            string inputLine;

                                            System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
                                            System.IO.StreamWriter sw = new System.IO.StreamWriter(outputFileName);

                                            inputLine = sr.ReadLine();
                                            while (inputLine != null)
                                            {
                                                if (inputLine.Length > 0)
                                                {
                                                    sw.WriteLine(inputLine);
                                                }
                                            // read the next line
                                            inputLine = sr.ReadLine();
                                            }
                                            sr.Close();
                                            sw.Close();

                                            var transf = System.IO.File.ReadAllText("solotemp.txt");
                                            System.IO.File.WriteAllText("solo.txt", transf);
                                            try
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
                                                Properties.Settings.Default.solo = "Для закрытия следующей Ямы-0, Колесом Фортуны избран " + lls + " !";
                                                Properties.Settings.Default.Save();
                                                await Bot.SendTextMessageAsync(message.Chat.Id, "В этот раз Фортуна избрала " + lls, replyToMessageId: message.MessageId);
                                                return;
                                            }
                                            catch
                                            {
                                                await Bot.SendTextMessageAsync(message.Chat.Id, "Список солистов пуст. Надо бы обновить");
                                                return;
                                            }
                                        }

                                        else
                                        {
                                            await Bot.SendTextMessageAsync(message.Chat.Id, name + " , мне не говорили, что тебе можно это делать. Извини.", replyToMessageId: message.MessageId);
                                            return;
                                        }

                                    }

                                //if (inmess.Contains("напомни мне")&&username.Equals("kanier"))
                                //    {
                                //        await Bot.SendTextMessageAsync(message.Chat.Id, "Хорошо, Хозяин!", replyToMessageId: message.MessageId);
                                //        return;
                                //    }

                                //else
                                //    {
                                //        await Bot.SendTextMessageAsync(message.Chat.Id, name + " , мне не говорили, что тебе можно это делать. Ничего личного.", replyToMessageId: message.MessageId);
                                //        return;
                                //    }


                                if (inmess.Contains("спасибо") || inmess.Contains("благодар"))
                                    {
                                        await Bot.SendTextMessageAsync(message.Chat.Id, name + ", не стоит. Мне было даже немного приятно)))");
                                        return;
                                    }

                                    await Bot.SendTextMessageAsync(message.Chat.Id, name + ", что за ересь? Я не понимаю, что ты имеешь в виду(((");
                                    return;
                                }
                            }
                            catch (Exception ex)
                            {
                                System.IO.File.AppendAllText("errorall.txt", DateTime.Now + "\r\n" + ex.Message + "\r\n");
                                return;
                            }

                try
                            {

                                if (message.Text.Equals("Ева") || message.Text.Equals("/info") || message.Text.Equals("/info@YavinIV_rollbot"))
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, "Слушаю тебя, " + name + "." + "\r\n" + "Что ты хочешь знать?" + "\r\n" + "Я могу напомнить тебе правила Ямы или ААТ, показать список солистов или памятку по ТБ. Могу напомнить, кто закрывает соло следующую Яму-0. И многое другое ;) Достаточно обратиться ко мне по имени. К примеру: \"Ева, кто закрывает соло?\"", replyToMessageId: message.MessageId);
                                    return;
                                }

                            }
                            catch (Exception ex)
                            {

                                System.IO.File.AppendAllText("errorall.txt", DateTime.Now + "\r\n" + ex.Message);
                                return;

                            }
                        }

                    };

                    // запускаем прием обновлений
                    Bot.StartReceiving();
                }
                catch (Telegram.Bot.Exceptions.ApiRequestException ex)
                {
                    System.IO.File.WriteAllText("error.log", ex.Message); // если ключ не подошел - пишем об этом в консоль отладки
                }

            }
            catch(Exception ex)
            {
                System.IO.File.AppendAllText("errorall.txt", ex.Message);
            }
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            //Тест
            //this.bw.RunWorkerAsync("358447207:AAEwJbHrp1HLgrGTrxtwtfvZ7FufHf8kW18");
            //Рабочий
            this.bw.RunWorkerAsync("399222874:AAFEZ3Q9nMq1kwkod9l4VMMaeRHX3uQ_xEc");
            lbl_status.ForeColor = System.Drawing.Color.Green;
            lbl_status.Text = "Бот запущен...";
            
        }

        

       
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telegram.Bot.Types;
using System.Text.RegularExpressions;
using System.Text;

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
                                var chatname = message.Chat.Title;
                                FileToSend vzhuh = new FileToSend("CAADAgADKwADCpgGDM8eYp6xnBJwAg");
                                FileToSend stick = new FileToSend("CAADAgADjAAD2kJgEdHmJbf9LcNAAg");
                                FileToSend kickstick = new FileToSend("CAADAgADFwADCpgGDPT5dlQ90N3vAg");
                                FileToSend gogo = new FileToSend("CAADAgADIgADCpgGDP2DujSOYxb2Ag");
                                FileToSend stb_1 = new FileToSend("CAADAgADKAADCpgGDAlPwj3jog11Ag");
                                FileToSend pipi = new FileToSend("MEDIA/bolt.jpg");
                                string offlist = System.IO.File.ReadAllText("offlist.txt");
                                string logs_pth = "LOGS/errorall.txt";


                try
                            {

                            ////if (message.Text.Equals("Запрос 900"))
                            ////    {
                            ////        string f1text = System.IO.File.ReadAllText("f1.txt");
                            ////        var stream1 = System.IO.File.Open("STB.jpg", FileMode.Open);
                            ////        FileToSend pipi1 = new FileToSend("STB.jpg",stream1);
                            ////        pipi1.Content = stream1;
                            ////        pipi1.Filename = "STB.jpg";
                            ////        await Bot.SendPhotoAsync(message.Chat.Id, photo: pipi1, caption: f1text);
                            ////        return;
                            ////    }
                            
                                    if (message.Text.ToLower().Contains("ридонли")  && offlist.Contains(username))
                                {
                                    var RoS = message.Text.ToString();
                                    Regex my_reg = new Regex(@"\D");
                                    string out_string = my_reg.Replace(RoS, "");
                                    int RoTime = Convert.ToInt32(out_string);
                                   
                                        DateTime untilDate = DateTime.Now.AddMinutes(RoTime);
                                        int iserid = message.ReplyToMessage.From.Id;
                                        string usrid = iserid.ToString();
                                        await Bot.RestrictChatMemberAsync(message.Chat.Id, iserid, untilDate);
                                        await Bot.SendStickerAsync(message.Chat.Id, vzhuh);
                                        await Bot.SendTextMessageAsync(message.Chat.Id, message.ReplyToMessage.From.FirstName + ", поздравляю!  В качестве бонуса, ты получаешь РО на " + RoTime.ToString() + " минут.", replyToMessageId: message.ReplyToMessage.MessageId);
                                        await Bot.DeleteMessageAsync(message.Chat.Id, message.MessageId);
                                        return;
                                    
                                }
                                //ДЛЯ ЕВЫ
                                if (message.Text.Contains("Ева, "))
                                {
                                    string inmess = message.Text.ToLower();
                                    //TEST CHAT ID
                                    System.IO.File.AppendAllText("LOGS/all_msg.txt", DateTime.Now +" "+chatname +" "+ username + " " + name +" "+ surname +"\r\n" + message.Text + "\r\n");
                                    string[] readText = System.IO.File.ReadAllLines(logs_pth, Encoding.Default);

                                    if (inmess.Contains("hooba") && username.Equals("kanier"))
                                    {

                                        
                                            //string last_ten = System.IO.File.ReadAllText("123.txt");
                                            //string n = readText[i];
                                            await Bot.SendTextMessageAsync(message.Chat.Id, System.IO.File.ReadAllText("LOGS/123.txt"));
                                        return;
                                        

                                    }
                                    if (inmess.Contains("покажи всё") && username.Equals("kanier"))
                                    {


                                        //string last_ten = System.IO.File.ReadAllText("123.txt");
                                        //string n = readText[i];
                                        await Bot.SendTextMessageAsync(message.Chat.Id, System.IO.File.ReadAllText(logs_pth));
                                        return;


                                    }
                                    if (inmess.Contains("срейд"))
                                    {
                                        string srtext = System.IO.File.ReadAllText("TEXT/sraid.txt");
                                        //await Bot.SendTextMessageAsync(message.Chat.Id, "[Тестовая ссылка из бота](https://t.me/iv?url=https%3A%2F%2Fyavin4.ru%2Fother%2Fthe-sith-triumvirate%2F&rhash=a6a7d09d8d0768)");
                                        await Bot.SendTextMessageAsync(message.Chat.Id, "Я просто оставлю это здесь...\n"+ srtext);
                                        return;
                                    }
                                    if (inmess.Contains("взвод"))
                                    {
                                        await Bot.SendTextMessageAsync(message.Chat.Id, "https://yavin4.ru/other/tb-platoons/"+ "\r\n"+"^^^^^^^^^^^^^^^^^^^^^^^^" +"\r\n"+"https://t.me/iv?url=https://yavin4.ru/other/tb-platoons/&rhash=a6a7d09d8d0768");
                                        return;


                                    }

                                    if (inmess.Contains("экстерминатус") && username.Equals("kanier") || inmess.Contains("экстерминатус") && username.Equals("vlad_o_v"))
                                    {

                                        var stream = System.IO.File.Open("MEDIA/flu.mp4", FileMode.Open);
                                        FileToSend fts = new FileToSend();

                                        //Stream stream_flu = null;
                                        fts.Content = stream;
                                        fts.Filename = "flu.mp4";



                                        DateTime ticker = DateTime.Now;
                                        Properties.Settings.Default.ticker_start = ticker;
                                        Properties.Settings.Default.Save();
                                        string txt_ticker = ticker.ToString();
                                        //await Bot.SendTextMessageAsync(message.Chat.Id, "Мне очень печально это говорить но, ПРИНЕСИТЕ FLUGGEGECHEIMEN!!!", replyToMessageId: message.MessageId);
                                        await Bot.SendDocumentAsync(message.Chat.Id, fts, "Мне очень печально это говорить но, ПРИНЕСИТЕ FLUGGEGECHEIMEN!!!");
                                        return;

                                    }
                                    if (inmess.Contains("счетчик")||inmess.Contains("счётчик"))
                                    {

                                        string old_ticker = Properties.Settings.Default.ticker_start.ToString();
                                        DateTime old_ticker_dt = Properties.Settings.Default.ticker_start;
                                        DateTime now_ticker_dt = DateTime.Now;
                                        TimeSpan alltime = now_ticker_dt - old_ticker_dt;
                                        //string final_count_full = alltime.ToString();
                                        //string final_count_short = final_count_full.Substring(0, final_count_full.LastIndexOf("."));
                                        //string final_count_wo_days = alltime.ToString("DD:MM:SS");
                                        //await Bot.SendTextMessageAsync(message.Chat.Id, "Новый отсчёт был запущен: " + old_ticker);
                                        await Bot.SendTextMessageAsync(message.Chat.Id, "На Явине всё спокойно уже: "+ string.Format("\nДней: {0:%d} \nЧасов: {0:%h} \nМинут: {0:%m} \nСекунд: {0:%s}",alltime)+ "\nОтсчёт был запущен: " + old_ticker);
                                        //await Bot.SendTextMessageAsync(message.Chat.Id, "Дней: " + final_count_short.Substring(0, final_count_short.LastIndexOf(".")));
                                        return;

                                    }


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
                                        if(inmess.Contains("в кантину кота"))
                                        {
                                            await Bot.SendStickerAsync("-1001033483774", vzhuh);
                                            return;
                                        }
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
                                 //if (inmess.Contains("гого")&& offlist.Contains(username))
                                 //   {
                                 //       try
                                 //       {
                                            
                                                
                                            
                                 //           //await Bot.SendDocumentAsync("-1001119850321", fts, "Все на ТБ!!!");
                                 //           await Bot.SendStickerAsync("-1001119850321", gogo);
                                 //           await Bot.SendStickerAsync("-1001121566331 ", gogo);
                                 //           //            //await Bot.SendDocumentAsync(message.Chat.Id, new FileToSend("GP.xlsx"));
                                 //           return;
                                 //       }
                                 //       catch (Exception ex)
                                 //       {
                                 //           System.IO.File.WriteAllText("LOGS/errorall.txt", ex.Message);
                                 //           //await Bot.SendTextMessageAsync(message.Chat.Id, "Что-то не так");
                                 //           return;
                                        
                                 //       }


                                 //   }
                                    if (inmess.Contains("привет") || inmess.Contains("как дела") || inmess.Contains("здрав"))
                                    {
                                        await Bot.SendTextMessageAsync(message.Chat.Id, "Привет, " + name + "." + "\r\n" + "Что ты хочешь знать?" + "\r\n" + "Я могу напомнить тебе правила Ямы или ААТ, показать список солистов или памятку по ТБ. Могу напомнить, кто закрывает соло следующую Яму-0. И многое другое ;) Достаточно обратиться ко мне по имени. К примеру: \"Ева, кто закрывает соло?\"", replyToMessageId: message.MessageId);
                                        return;
                                    }
                                    if (inmess.Contains("соло") || inmess.Contains("закрывает"))

                                    {
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

                                    //ТЕСТ РИДОНЛИ

                                    


                                    if (inmess.Contains("накати") || inmess.Contains("рря") || inmess.Contains("тост"))
                                    {
                                        List<string> lstT = new List<string>();
                                        Random randT = new Random();
                                        var inxT = System.IO.File.ReadAllLines("TEXT/tost.txt");
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
                                            string f1text = System.IO.File.ReadAllText("TEXT/STB/f1.txt");
                                            string f2text = System.IO.File.ReadAllText("TEXT/STB/f2.txt");
                                            string f3text = System.IO.File.ReadAllText("TEXT/STB/f3.txt");
                                            string f4text = System.IO.File.ReadAllText("TEXT/STB/f4.txt");
                                            string f5text = System.IO.File.ReadAllText("TEXT/STB/f5.txt");
                                            string f6text = System.IO.File.ReadAllText("TEXT/STB/f6.txt");
                                            var stream1 = System.IO.File.Open("MEDIA/STB.jpg", FileMode.Open);
                                            FileToSend pipi1 = new FileToSend("MEDIA/STB.jpg", stream1)
                                            {
                                            Content = stream1,
                                            Filename = "MEDIA/STB.jpg"
                                            };

                                            if (inmess.Contains("1"))
                                            {
                                            await Bot.SendPhotoAsync(message.Chat.Id, photo: pipi1);
                                            await Bot.SendTextMessageAsync(message.Chat.Id, f1text);
                                            return;
                                            }

                                            if (inmess.Contains("2"))
                                            {
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
                                        
                                       
                                        string tbfile = System.IO.File.ReadAllText("TEXT/STB/tb.txt");
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
                                        var inxR = System.IO.File.ReadAllLines("TEXT/rancor.txt");
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
                                            string lstall = System.IO.File.ReadAllText("TEXT/solo.txt");
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
                                   if (inmess.Contains("аат") || inmess.Contains("танк"))
                                    {
                                        List<string> lstR = new List<string>();
                                        var inxR = System.IO.File.ReadAllLines("TEXT/aat.txt");
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
                                            var soloL = System.IO.File.ReadAllText("TEXT/solo.txt");
                                            var soloX = soloL.Replace(lastsolo, "");
                                        //var soloF = soloX.Replace("\n\n", "\n");
                                        //var lines = System.IO.File.ReadAllLines("solo.txt");
                                        //string[] linesX = lines.re
                                        //System.IO.File.WriteAllLines("solo.txt", lines);
                                        //MessageBox.Show(lastsolo);
                                        //MessageBox.Show(soloF);
                                        System.IO.File.WriteAllText("TEXT/solo.txt", soloX);

                                            string fileName = "TEXT/solo.txt";
                                            string outputFileName = "TEXT/solotemp.txt";
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

                                            var transf = System.IO.File.ReadAllText("TEXT/solotemp.txt");
                                            System.IO.File.WriteAllText("TEXT/solo.txt", transf);
                                            try
                                            {
                                                List<string> lst = new List<string>();

                                                Random rand = new Random();

                                                var inx = System.IO.File.ReadAllLines("TEXT/solo.txt");

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
                                System.IO.File.AppendAllText(logs_pth, "\r\n" + DateTime.Now + "\r\n" + ex.Message + "\r\n");
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

                                System.IO.File.AppendAllText(logs_pth, "\r\n"+DateTime.Now + "\r\n" + ex.Message + "\r\n");
                                System.IO.File.WriteAllText("LOGS/123.txt", "\r\n"+DateTime.Now + "\r\n" + ex.Message + "\r\n");
                                return;

                            }
                        }

                    };

                    // запускаем прием обновлений
                    Bot.StartReceiving();
                }
                catch (Telegram.Bot.Exceptions.ApiRequestException ex)
                {
                    System.IO.File.WriteAllText("LOGS/error.log", "\r\n"+DateTime.Now + "\r\n" + ex.Message + "\r\n"); // если ключ не подошел - пишем об этом в консоль отладки
                }

            }
            catch(Exception ex)
            {
                System.IO.File.AppendAllText("LOGS/errorall.txt", "\r\n"+ DateTime.Now + "\r\n" + ex.Message + "\r\n");
                System.IO.File.WriteAllText("LOGS/123.txt", "\r\n"+DateTime.Now + "\r\n" + ex.Message + "\r\n");
            }
        }

       
        private void Form1_Load(object sender, EventArgs e)

       
        {
            Timer Timer1 = new Timer
            {
                Interval = 60000
            };
            Timer1.Tick += Timer1_Tick;
            Timer1.Enabled = true;


            //Тест
            //this.bw.RunWorkerAsync("358447207:AAEwJbHrp1HLgrGTrxtwtfvZ7FufHf8kW18");
            //Рабочий
            this.bw.RunWorkerAsync("399222874:AAFEZ3Q9nMq1kwkod9l4VMMaeRHX3uQ_xEc");
            lbl_status.ForeColor = System.Drawing.Color.Green;
            lbl_status.Text = "Бот запущен...";
            Properties.Settings.Default.temp = "399222874:AAFEZ3Q9nMq1kwkod9l4VMMaeRHX3uQ_xEc";
            Properties.Settings.Default.Save();


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int time_now_hour = DateTime.Now.Hour;
            int time_now_min = DateTime.Now.Minute;
            Properties.Settings.Default.hour_now = time_now_hour;
            Properties.Settings.Default.min_now = time_now_min;
            Properties.Settings.Default.Save();
        }
    }
}

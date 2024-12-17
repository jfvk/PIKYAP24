using System;
using System.Diagnostics.Eventing.Reader;
using Microsoft.AspNetCore.Identity;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
namespace Meow
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new TelegramBotClient("7811576328:AAExXI-v7kot2w-fy5mPWXkhoB4Do_p_gM8");
            client.StartReceiving(Update, Мetod1);
            Console.ReadLine();
        }

        private static async Task Мetod1(ITelegramBotClient client, Exception exception, HandleErrorSource source, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        async static Task Update(ITelegramBotClient client, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message.Text != null)
            {
                Console.WriteLine($"{message.Chat.FirstName} | {message.Text}");
                if (message.Text.ToLower().Contains("привет"))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Привет, Котик! :3");

                }
                if (message.Text.ToLower().Contains("как дела"))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Я как всегда замурчательно, а ты?");

                }
                if (message.Text.ToLower().Contains("плохо"))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Не плакай :( ! Ты справишься! :3");

                }
                if (message.Text.ToLower().Contains("грустно"))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Всё хорошо, студент! Закроешься, да и новый год скоро! :3");

                }
                if (message.Text.ToLower().Contains("хорошо"))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Так держать! ;3");

                }
                if (message.Text.ToLower().Contains("что") & message.Text.ToLower().Contains("делаешь"))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Жду товего сообщения! :3");

                }
                if (message.Text.ToLower().Contains("расскажи"))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Хм. А что мне тебе рассказать? Могу ли чем-то помочь?");

                }
                if ((message.Text.ToLower().Contains("о") & message.Text.ToLower().Contains("себе")) || (message.Text.ToLower().Contains("кто") & message.Text.ToLower().Contains("ты")))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Я Meow.Bot, на самом деле я задание по ПиКЯП. " +
                        "               Могу поддержать хихихи или помочь выбрать подарочек на Новый Год! Да, да, сейчас это актуально!) " +
                        "               Кстати, подписывайся наи тгшку моей хозяйки: https://t.me/jeannefrederica ! " +
                        "                                                               Если у тебя есть какой то вопрос или тебе нужна помощь, обращайся! :3");

                }

                if (message.Text.ToLower().Contains("выбрать ") & message.Text.ToLower().Contains("подарок"))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Оооо да. А кому подарочек?");

                }
                if (message.Text.ToLower().Contains("подруге") || message.Text.ToLower().Contains("бабушке") || message.Text.ToLower().Contains("маме") || message.Text.ToLower().Contains("тёте") || message.Text.ToLower().Contains("сестре") || message.Text.ToLower().Contains("девушке") || message.Text.ToLower().Contains("племяннице"))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Как мило! А, а какое у неё хобби? Чем увлекается?");

                }
                if (((message.Text.ToLower().Contains("не")) & message.Text.ToLower().Contains("знаю")) & (message.Text.ToLower().Contains("она") || message.Text.ToLower().Contains("ей") || message.Text.ToLower().Contains("неё")))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Подари своей любимке подарочную карту от Gold Apple! Множество бьюти товаров и не только на абсолютно любой вкус! Переходи по ссылке: https://goldapple.ru/ ");
                }

                if (message.Text.ToLower().Contains("другу") || message.Text.ToLower().Contains("дедушке") || message.Text.ToLower().Contains("папе") || message.Text.ToLower().Contains("дяде") || message.Text.ToLower().Contains("брату") || message.Text.ToLower().Contains("парню") || message.Text.ToLower().Contains("племяннику"))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Как мило! А, а какое у него хобби? Чем увлекается?");
                }
                if (((message.Text.ToLower().Contains("не")) & message.Text.ToLower().Contains("знаю")) & (message.Text.ToLower().Contains("он") || message.Text.ToLower().Contains("ему") || message.Text.ToLower().Contains("него")))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Ничего! Скорее залетай на Яндекс Маркет и там найдёшь всё самое классное: https://market.yandex.ru/");
                }
                if (message.Text.ToLower().Contains("макияж") || message.Text.ToLower().Contains("косметика") || message.Text.ToLower().Contains("краситься"))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Отлично подойдут адвент календари! Cкорее смотри по ссылке тут: https://www.letu.ru/compilations/advent");
                    await client.SendTextMessageAsync(message.Chat.Id, "И тут: https://goldapple.ru/s/advent-kalendar?srsltid=AfmBOoqcSuYesmjTG99XH5jO5pXJ9gRlkYEl1rFNVC8gvXNDQKDNMl0B ");
                    await client.SendTextMessageAsync(message.Chat.Id, "И вот тут https://rivegauche.ru/tags/advent-kalendari-kosmetiki");
                }
                if (message.Text.ToLower().Contains("одежда") || message.Text.ToLower().Contains("мода") || message.Text.ToLower().Contains("сумк"))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Скорее заглядывай на lamoda :) Мультибрендовый маркетплейс с  флагманским магазнами и гарантией оригинального качества) Также на lamoda появились сертификаты! Чекай ссылочку: https://www.lamoda.ru");
                }
                if (message.Text.ToLower().Contains("не") &  message.Text.ToLower().Contains("знаю"))
                    {
                    await client.SendTextMessageAsync(message.Chat.Id, "Не беда! Конечно, иногда выведать, что человек хочет в подарок сложно. Ты можешь подарить классичсеские подарочки, как милые пижамы, носочки, свечки, фулл акк или же сертефикат на любом маркетплейсе. А чтобы всегда быть в курсе хотелок твоих друзей, устнавливай приложение Oh my wishes и всегда будь в курсе wishlistа твоих бро:https://ohmywishes.com/ ");
                }
            }
            if (message.Photo != null)
            {
                await client.SendTextMessageAsync(message.Chat.Id, "Ох уж этот дуровский формат сжатых фоток...Отправь мне файл документиком с хорошим качеством! ;3");
            }
            if (message.Document != null)
                await client.SendTextMessageAsync(message.Chat.Id, "Мяу мяу, cмотрю-смотрю ;3");
        }

        private static async Task Metod1(ITelegramBotClient client, Exception exception, HandleErrorSource source, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}

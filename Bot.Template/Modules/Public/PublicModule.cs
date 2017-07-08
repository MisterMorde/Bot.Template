﻿using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Discord.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Bot.Template.Modules.Public
{
    public class PublicModule : ModuleBase
    {

        [Command("test")] //Command Name
        [Remarks("Tests your bot to see if it worked ;)")] //Summary for your command. it will not add anything.
        public async Task Test()
        {
            try // Try the following code, if failed - move to "catch"
            {
                await ReplyAsync("Test Command Successful"); //makes the bot reply back!      
            }
            catch (Exception e) // catch exception error, reply with the error in string format
            {
                await ReplyAsync(e.ToString());
            }
        }
    }
}
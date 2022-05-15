﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Console
{
    internal class Animation
    {

        public static void ChestAnimationIdle()
        {
            Console.Clear();
            Console.WriteLine($"                                              \n" +
                              $"                                              \n" +
                              $"                                              \n" +
                              $"                                              \n" +
                              $"    ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓    \n" +
                              $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                              $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                              $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                              $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                              $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                              $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                              $"    ▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░██    \n" +
                              $"    ▓▓░░▒▒▒▒▒▒▒▒░░▓▓░░░░▓▓▒▒░░▒▒░░░░▒▒░░██    \n" +
                              $"  ▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒  \n" +
                              $"▒▒▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▒▒▒▒\n" +
                              $"▒▒▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▒▒▒▒\n" +
                              $"▒▒▒▒▓▓░░▓▓▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▓▓░░▓▓▒▒▒▒\n" +
                              $"▒▒▒▒▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░▓▓▒▒▒▒\n" +
                              $"▒▒▒▒▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓▒▒▒▒\n" +
                              $"▒▒▒▒▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▒▒▒▒\n" +
                              $"▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒\n" +
                              $"▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n" +
                              $"  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \n");
            Console.WriteLine("Press a key to open the chest!");
            Console.ReadKey();
            AnimationChestOpen();
        }   //Display Idle chest
        public static void AnimationChestOpen()
        {
            Console.Clear();
            Console.WriteLine($"                                              \n" +
                              $"                                              \n" +
                              $"                                              \n" +
                              $"                                              \n" +
                              $"    ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓    \n" +
                              $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                              $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                              $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                              $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                              $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                              $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                              $"    ▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░██    \n" +
                              $"    ▓▓░░▒▒▒▒▒▒▒▒░░▓▓░░░░▓▓▒▒░░▒▒░░░░▒▒░░██    \n" +
                              $"  ▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒  \n" +
                              $"▒▒▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▒▒▒▒\n" +
                              $"▒▒▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▒▒▒▒\n" +
                              $"▒▒▒▒▓▓░░▓▓▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▓▓░░▓▓▒▒▒▒\n" +
                              $"▒▒▒▒▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░▓▓▒▒▒▒\n" +
                              $"▒▒▒▒▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓▒▒▒▒\n" +
                              $"▒▒▒▒▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▒▒▒▒\n" +
                              $"▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒\n" +
                              $"▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n" +
                              $"  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \n");
            Console.Clear();
            Console.WriteLine($"                                                \n" +
                                $"                                              \n" +
                                $"                                              \n" +
                                $"                                              \n" +
                                $"    ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓    \n" +
                                $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                                $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                                $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                                $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██    \n" +
                                $"    ▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░██    \n" +
                                $"    ▓▓░░▒▒▒▒▒▒▒▒░░▓▓░░░░▓▓▒▒░░▒▒░░░░▒▒░░▓▓    \n" +
                                $"    ▓▓░░▒▒▒▒▒▒▒▒░░▓▓▒▒▒▒▓▓▒▒░░▒▒░░░░▒▒░░▓▓    \n" +
                                $"    ▓▓▒▒░░░░░░░░░░░░▓▓▓▓░░░░░░░░░░░░▒▒░░▓▓    \n" +
                                $"  ▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▒▒  \n" +
                                $"▒▒▒▒▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▒▒▒▒\n" +
                                $"▒▒▒▒▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▒▒▒▒\n" +
                                $"▒▒▒▒▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░▓▓▒▒▒▒\n" +
                                $"▒▒▒▒▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░▓▓▒▒▒▒\n" +
                                $"▒▒▒▒▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓▒▒▒▒\n" +
                                $"▒▒▒▒▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▒▒▒▒\n" +
                                $"▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒\n" +
                                $"▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n" +
                                $"  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \n");
            Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine($"                                               \n" +
                                $"                                               \n" +
                                $"    ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓     \n" +
                                $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██     \n" +
                                $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██     \n" +
                                $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██     \n" +
                                $"    ▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░██     \n" +
                                $"    ▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░██     \n" +
                                $"    ▓▓░░▒▒▒▒▒▒▒▒░░▓▓░░░░▓▓▒▒░░▒▒░░░░▒▒░░▓▓     \n" +
                                $"    ▓▓░░▒▒▒▒▒▒▒▒░░▓▓▒▒▒▒▓▓▒▒░░▒▒░░░░▒▒░░▓▓     \n" +
                                $"    ▓▓▒▒░░░░░░░░░░░░▓▓▓▓░░░░░░░░░░░░▒▒░░▓▓     \n" +
                                $"    ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▓▓     \n" +
                                $"    ▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓     \n" +
                                $"  ▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▒▒   \n" +
                                $"▒▒▒▒▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▒▒▒▒ \n" +
                                $"▒▒▒▒▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▒▒▒▒ \n" +
                                $"▒▒▒▒▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░▓▓▒▒▒▒ \n" +
                                $"▒▒▒▒▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░▓▓▒▒▒▒ \n" +
                                $"▒▒▒▒▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓▒▒▒▒ \n" +
                                $"▒▒▒▒▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▒▒▒▒ \n" +
                                $"▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒ \n" +
                                $"▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ \n" +
                                $"  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \n");
            Thread.Sleep(50);
            Console.Clear();
            Console.WriteLine($"                    ▓▓▓▓                     \n" +
                                $"    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒     \n" +
                                $"    ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓     \n" +
                                $"    ▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓     \n" +
                                $"    ▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓     \n" +
                                $"    ▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓     \n" +
                                $"    ▓▓▓▓▓▓▓▓▓▓░░░░░░░░▓▓▓▓░░░░░░▓▓▓▓▓▓▓▓▓▓     \n" +
                                $"    ▓▓▓▓▓▓▓▓▓▓░░░░░░░░▓▓▒▒░░░░░░▓▓▓▓▓▓▓▓▓▓     \n" +
                                $"    ▓▓░░▓▓▓▓░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓░░▓▓     \n" +
                                $"    ▓▓░░▓▓░░░░▒▒░░░░░░░░▒▒▒▒░░░░░░░░▓▓░░▓▓     \n" +
                                $"    ▓▓░░▓▓░░▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░▓▓     \n" +
                                $"    ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓     \n" +
                                $"    ▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓     \n" +
                                $"  ▒▒▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓▒▒   \n" +
                                $"▒▒▒▒▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░▓▓▒▒▒▒ \n" +
                                $"▒▒▒▒▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░▓▓▒▒▒▒ \n" +
                                $"▒▒▒▒▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░▓▓▒▒▒▒ \n" +
                                $"▒▒▒▒▓▓░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░▓▓▒▒▒▒ \n" +
                                $"▒▒▒▒▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓▒▒▒▒ \n" +
                                $"▒▒▒▒▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▒▒▒▒ \n" +
                                $"▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒ \n" +
                                $"▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ \n" +
                                $"  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒   \n");
        }  //Display opening chest animation.
        public static void SleepingAnimation()
        {
            Console.Clear();
            Console.WriteLine("						\n" +
                              "			    		\n" +
                              "			    		\n" +
                              "			     		");
            Console.WriteLine(@"      _____|~~\_____      _____________	");
            Console.WriteLine(@"  _-~               \    |    \		 ");
            Console.WriteLine(@"  _-    | )     \    |__/   \   \		");
            Console.WriteLine(@"  _-         )   |   |  |     \  \		");
            Console.WriteLine("._ -    | ) /    | --|      |  | \n" +
                              " __-_______________ /__/_______|  |_________	\n" +
                              "(                |----         |  |		\n");
            Console.WriteLine(@" `---------------'--\\\\      .`--'		");
            Console.WriteLine("                              `||||		");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("						\n" +
                              "			    		\n" +
                              "			    		\n" +
                              "			Z    		");
            Console.WriteLine(@"      _____|~~\_____      _____________	");
            Console.WriteLine(@"  _-~               \    |    \		 ");
            Console.WriteLine(@"  _-    | )     \    |__/   \   \		");
            Console.WriteLine(@"  _-         )   |   |  |     \  \		");
            Console.WriteLine("._ -    | ) /    | --|      |  | \n" +
                              " __-_______________ /__/_______|  |_________	\n" +
                              "(                |----         |  |		\n");
            Console.WriteLine(@" `---------------'--\\\\      .`--'		");
            Console.WriteLine("                              `||||		");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("						\n" +
                              "			    		\n" +
                              "			   Z		\n" +
                              "			Z    		");
            Console.WriteLine(@"      _____|~~\_____      _____________	");
            Console.WriteLine(@"  _-~               \    |    \		 ");
            Console.WriteLine(@"  _-    | )     \    |__/   \   \		");
            Console.WriteLine(@"  _-         )   |   |  |     \  \		");
            Console.WriteLine("._ -    | ) /    | --|      |  | \n" +
                              " __-_______________ /__/_______|  |_________	\n" +
                              "(                |----         |  |		\n");
            Console.WriteLine(@" `---------------'--\\\\      .`--'		");
            Console.WriteLine("                              `||||		");

            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("			      			\n" +
                              "                      Z		\n" +
                              "			   Z		\n" +
                              "			Z    		");
            Console.WriteLine(@"      _____|~~\_____      _____________	");
            Console.WriteLine(@"  _-~               \    |    \		 ");
            Console.WriteLine(@"  _-    | )     \    |__/   \   \		");
            Console.WriteLine(@"  _-         )   |   |  |     \  \		");
            Console.WriteLine("._ -    | ) /    | --|      |  | \n" +
                              " __-_______________ /__/_______|  |_________	\n" +
                              "(                |----         |  |		\n");
            Console.WriteLine(@" `---------------'--\\\\      .`--'		");
            Console.WriteLine("                              `||||		");
            Console.WriteLine("You feel rested. All your injuries have healed.");
            Console.ReadKey();
        }    //Display the player's sleeping animation.
    }
}

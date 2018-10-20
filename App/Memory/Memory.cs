using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal partial class Memory
    {
        private string gameLanguage;
        internal bool IsRunning { get; private set; } = false;

        internal Memory(string language)
        {
            SetLanguague(language);
        }
        
        internal void StartCapture(Process process)
        {
        }

        internal void SetLanguague(string language)
        {
            switch (language)
            {
                case "ko-kr":
                    gameLanguage = "Korean";
                    break;

                case "en-us":
                    gameLanguage = "English";
                    break;

                case "fr-fr":
                    gameLanguage = "French";
                    break;

                case "ja-jp":
                    gameLanguage = "Japanese";
                    break;

                case "zh-cn":
                    gameLanguage = "Chinese";
                    break;

                default:
                    return;
            }
        }
    }
}

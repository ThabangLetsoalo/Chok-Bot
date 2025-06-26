using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MainLogic : Utilities
    {
        public String Answer;
        public String replie;
        public string botRes;
        public String name;

        private static readonly Random random = new Random();

        private static readonly Dictionary<string, List<string>> Responses = new Dictionary<string, List<string>>
        {
            { "what is your purpose", new List<string> { "I am a Cyber-Security Awareness Bot.", "I help answer questions about Cyber-Security.", "My goal is to educate users on safe online practices." } },
            { "password", new List<string> { "🔐 Use strong, unique passwords for each account.", "🔑 Never reuse the same password across multiple sites.", "🛡 Use a password manager to store and generate secure passwords.", "🔏 Your password should be at least 12–16 characters long with a mix of letters, numbers, and symbols." } },
            { "phishing", new List<string> { "📧 Beware of phishing emails. Don't click on unknown links.", "🚨 Always verify the sender’s email address before responding.", "🔍 Look for spelling mistakes and urgent language in emails—they are common signs of phishing.", "🛑 Never share personal information via email, even if it looks official." } },
            { "safe browsing", new List<string> { "🌐 Always check for 'https://' before entering sensitive information on websites.", "🛡 Use a secure and updated web browser with built-in security features.", "🔍 Be cautious when downloading files from unknown sources.", "⚠ Avoid clicking on pop-up ads or suspicious links." } },
            { "malware", new List<string> { "🦠 Don't download files or software from untrusted websites.", "🔍 Scan email attachments before opening them, even if they come from a trusted sender.", "⚙ Keep your operating system and software updated to fix security vulnerabilities.", "🛑 Avoid using cracked or pirated software—it often contains hidden malware." } },
            { "cyber security tips", new List<string> { "🔐 Use strong, unique passwords for each account.", "📧 Beware of phishing emails. Don't click on unknown links.", "🔒 Enable two-factor authentication for extra security.", "🛡 Keep your software and antivirus up to date." } },
            { "virus", new List<string> { "🦠 A virus is a type of malware that attaches itself to files and spreads when executed.", "⚠️ Avoid downloading suspicious files to prevent viruses.", "🛡 Keep your antivirus software updated to detect and remove viruses.", "🔍 Scan files before opening them to avoid getting infected." } },
            { "worm", new List<string> { "🪱 A worm is a self-replicating malware that spreads without human intervention.", "⚠️ Worms exploit vulnerabilities in networks to spread.", "🛡 Keep your system updated to patch security holes and prevent worm infections.", "🔍 Avoid clicking on unknown email attachments that may contain worms." } },
            { "trojan", new List<string> { "🎭 A Trojan horse is a type of malware disguised as a legitimate program.", "⚠️ Trojans do not replicate but can create backdoors for hackers.", "🛡 Be cautious when downloading software from untrusted sources.", "🔍 Use antivirus software to detect and remove Trojans before they cause harm." } },
            { "ransomware", new List<string> { "💰 Ransomware encrypts your files and demands a ransom for decryption.", "⚠️ Avoid opening email attachments from unknown senders to prevent ransomware infections.", "🛡 Regularly back up important files to recover data in case of a ransomware attack.", "🔍 Keep security software updated to detect and block ransomware threats." } },
            { "spyware", new List<string> { "🕵️ Spyware secretly monitors your activity and collects personal information.", "⚠️ Be cautious when installing free software, as it may include spyware.", "🛡 Use anti-spyware tools to detect and remove spyware from your system.", "🔍 Avoid clicking on suspicious links that may lead to spyware downloads." } }
        };

        public void Response()
        {
            foreach (var keyword in Responses.Keys) // loops through the dictionery 
            {
                if (Answer.Contains(keyword))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    //TypeEffect($"🤖 {GetRandomResponse(keyword)}", 40);
                    botRes = GetRandomResponse(keyword);
                    return;
                }
            }
            // If no match is found
            TypeEffect("🤖 I didn’t quite understand that. Could you rephrase?", 40);
        } //end of response\
        private string GetRandomResponse(string key) // get a random item from the list of the keyword
        {
            var respons = Responses[key];
            return respons[random.Next(respons.Count)];
        }
        

        public void HUDResponse()
        {
            if (replie.Contains("good") || replie.Contains("great") || replie.Contains("fine") || replie.Contains("happy"))
            {
                //ChatListBox.Items.Add($"🤖 I'm glad to hear that {userName}! How can I assist you today?");
                Answer = $"🤖 I'm glad to hear that {name}! ";
            }
            else if (replie.Contains("not good") || replie.Contains("bad") || replie.Contains("sad") || replie.Contains("angry"))
            {
                //ChatListBox.Items.Add($"🤖 I'm sorry to hear that {userName}.");
                Answer = $"🤖 I'm sorry to hear that {name}.";
            }
            else
            {
                //ChatListBox.Items.Add($"🤖 I didn't quite understand that. Could you rephrase?");
                Answer = $" I didn't quite understand that. Could you rephrase?";
            }
        } 
    
    }
}
using UnityEngine;
using System.Collections;

public class Help : MonoBehaviour {
	void OnGUI(){
		
		// Get button style and center
		var centeredStyle = new GUIStyle(GUI.skin.button);
		centeredStyle.alignment = TextAnchor.MiddleCenter;
		  
		GUI.Label (new Rect (0.18f * Screen.width, 0.1f * Screen.height, 250, 120), "SpamFilter \nThe Spam Filter is primarily used to combat email spam. This is done by junking/deleting suspicious emails that may contain harmful software such as malware or phishing links.");
		GUI.Label (new Rect (0.18f * Screen.width, 0.41f * Screen.height, 250, 120), "Antivirus Software \nAntivirus software is used to prevent malware and viruses from accessing your PC. It does this by scanning all incoming/existing files for threats.");
		GUI.Label (new Rect (0.18f * Screen.width, 0.76f * Screen.height, 250, 120), "Firewall \nThe Firewall prevents unauthorised access to computer systems by securing/closing unused ports and by monitoring incoming and outgoing traffic for suspicious activity.");

		// 950
		// 550

		GUI.Label (new Rect (0.68f * Screen.width, 0.1f * Screen.height, 250, 120), "SpamMail \nSpam Mail can be a threat to computer systems as it will often contain harmful malware embedded in attachments, or links to phishing sites. Most Spam Mail will be sent from a bot immitating an email that you recognise.");
		GUI.Label (new Rect (0.68f * Screen.width, 0.41f * Screen.height, 250, 120), "Virus \nViruses are used to infiltrate a computer system, often embedded in spam mail, intent on causing damage to the system. This could include corrupting sensitive data, transmitting data back to the author or crashing critical systems.");
		GUI.Label (new Rect (0.68f * Screen.width, 0.76f * Screen.height, 250, 120), "DDOS (Denial-of-Service) \nDDOS attacks are used to overwhel, a computer ysstem or network with heigh amounts of traffic, with the intention to cause distruption and outage of the network.");

		// Spam Mail can be a threat to computer systems as it will often contain harmful malware embedded in attachments, or links to phishing sites. Most Spam Mail will be sent from a bot immitating an email that you recognise. Weak against SpamFilters.
		// Viruses are used to infiltrate a computer system, often embedded in spam mail, intent on causing damage to the system. This could include corrupting sensitive data, transmitting data back to the author or crashing critical systems. Weak against antivirus software.
		// DDOS attacks are used to overwhel, a computer ysstem or network with heigh amounts of traffic, with the intention to cause distruption and outage of the network. Weak against firewalls.

		if(GUI.Button(new Rect(25, Screen.height - 60, 100, 40), "Back", centeredStyle)){
			Application.LoadLevel("Menu");
		}
	}
}

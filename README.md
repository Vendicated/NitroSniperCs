```
███╗   ██╗██╗████████╗██████╗  ██████╗ ███████╗███╗   ██╗██╗██████╗ ███████╗██████╗ 
████╗  ██║██║╚══██╔══╝██╔══██╗██╔═══██╗██╔════╝████╗  ██║██║██╔══██╗██╔════╝██╔══██╗
██╔██╗ ██║██║   ██║   ██████╔╝██║   ██║███████╗██╔██╗ ██║██║██████╔╝█████╗  ██████╔╝
██║╚██╗██║██║   ██║   ██╔══██╗██║   ██║╚════██║██║╚██╗██║██║██╔═══╝ ██╔══╝  ██╔══██╗
██║ ╚████║██║   ██║   ██║  ██║╚██████╔╝███████║██║ ╚████║██║██║     ███████╗██║  ██║
╚═╝  ╚═══╝╚═╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚═╝╚═╝     ╚══════╝╚═╝  ╚═╝
```

A discord selfbot that automatically detects discord nitro codes in messages and attempts to redeem

> ⚠️ THIS TOOL VIOLATES DISCORDS TERMS OF SERVICE AND MIGHT GET YOU PERMAMENTLY BANNED. USE AT YOUR OWN RISK!

## Explanation
This tool can use 1 or multiple discord accounts. These will be differentiated into two categories:
- Master: The main account. This account will NOT be logged into, so the risk of it getting banned are very slim
- Slaves: One or more accounts. This tool will log into each of these accounts and monitor messages on every server these accounts are on. These accounts have a high risk of getting banned eventually, so use with care.

You will have to aquire your Discord User Agent and Token(s) - [Guide](https://gist.github.com/Vendicated/e7318adb486bb507facb70539e188c1c)

## Setup
- Download the latest Release
- Rename `config.example.json` to `config.json`
- Fill out its field accordingly:
  - master: this is the token of your main account where discovered codes will be redeemed
  - userAgent: This is the User Agent of your discord app
  - slaves: A list of tokens of alt accounts (or alternatively your main), seperated by commas
  - webhook: A discord webhook link. This will be used to log discovered codes directly to discord. ([Guide](https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks))
- Run `NitroSniper.exe`

<details>
  <summary>Example config</summary>
  
  ```json
{
    "master": "mfa._RL3NL2U5K0-9DG793KH7VVGXPAA8FYV6XOBQ11ADF_MDB0VRK1OTFM76JRCZHXUBTZ6RYZQY",
    "userAgent": "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) discord/0.0.309 Chrome/83.0.4103.122 Electron/9.3.5 Safari/537.36",
    "slaves": [ "mfa._1KWXL5P814-51JWFZ45RUQPYHY7M9D920LJS0HCJ7_TTI8T9KCAUF56TSEU1CO34TS10ARBT", "mfa._X0EC0GRRTP-SA9M6EAYGBOL1YEM588S80S4QV3UJX_MQHYVYIMRNG96FWBPI228CKK0BPTUG" ],
    "webhook": "https://discord.com/api/webhooks/80121892182894627594/ASkjjsa991-sa29S-8sahjsjahshjSHAjhsjajhs
}
  ```
  
</details>



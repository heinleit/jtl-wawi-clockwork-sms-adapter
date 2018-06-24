# Clockwork SMS-Adapter

Mit dieser Befehlszeilenanwendung, können Sie mithilfe von [Clockwork-SMS](https://www.clockworksms.com/) direkte SMS-Mitteilungen direkt aus einem Workflow heraus senden.

[Aktueller Download (x86)](https://github.com/heinleit/jtl-wawi-clockwork-sms-adapter/releases)

## Wie?

1. Clockwork-SMS-Account anlegen, Guthaben aufladen und API-Token generieren
2. Workflow anlegen, konfigurieren
3. Aktion anlegen: *Ausführen*
4. Programm/Script: Datei auswählen, **JTL-Wawi_Clockwork.exe** auswählen
5. Parameter: `[API-Token] [Rufnummer] "[Text]" 49`

Im Workflow-Log lässt sich ebenfalls die Fehlerausgabe der Anbindung anzeigen.

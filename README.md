# Oefening 4: DecNaarBin

Schrijf 2 functiemethodes *DecimalToBinary(string)* en
*DecimalToBinaryUntil255(string)* om een decimaal getal om te zetten
naar een binair getal.

![Afbeelding met tekst, schermopname, Lettertype, nummer Automatisch
gegenereerde
beschrijving](./media/image1.png) **2^8^ 2^7^ 2^6^ 2^5^ 2^4^ 2^3^ 2^2^ 2^1^ 2^0^**

![Afbeelding met tekst, nummer, schermopname, Lettertype Automatisch
gegenereerde beschrijving](./media/image2.png)

Dus: Bereken voor elk cijfer 1 in het binaire getal, de overeenkomstige
macht van 2. Een binair getal van 6 cijfers, bijvoorbeeld 111111, wordt
vertaald in (van links naar rechts) 32, 16, 8, 4, 2 en 1. De som 32 +
16 + 8 + 4 + 2 + 1 = 63 is de decimale waarde van dit binaire getal. Zo
wordt 010101: 16 + 4 + 1 = 21 in decimale waarden.

![Afbeelding met tekst, schermopname, software Automatisch gegenereerde
beschrijving](./media/image3.png)

Indien er een groter getal dan 255 wordt ingegeven en er wordt op de
eerste knop geklikt, dan wordt er een foutmelding gegeven.

![Afbeelding met tekst, schermopname, Lettertype, nummer Automatisch
gegenereerde
beschrijving](./media/image4.png)

In *DecimalToBinary* () wordt gebruikgemaakt van de restdeling.

Vb. 29/2 = 14 rest = 1

14/2 = 7 rest = 0

7/2 = 3 rest = 1

3/2 = 1 rest = 1

1/2 = 0 rest = 1 het binaire getal 10111 moet omgekeerd worden en het
uiteindelijke resultaat is 00011101 (vooraan 2 nullen toevoegen tot 8
posities)

In *DecimalToBinaryUntil255*() kunnen enkel getallen tot 255 (2^8^)
omgezet worden en wordt de volgende berekening gevolgd:

29/ 128 = 0 rest = 29 - 2^7^ = 128

29/ 64 = 0 rest = 29 - 2^6^ = 64

29/32 = 0 rest = 29 - 2^5^ = 32

29/16 = 1 rest = 13 - 2^4^ = 16

13/8= 1 rest = 5 - 2^3^ = 8

5/4 = 1 rest= 1 - 2^2^ = 4

1/2 = 0 rest = 0 - 2^1^ = 2

1/1 = 1 rest = 0 - 2^0^ = 1

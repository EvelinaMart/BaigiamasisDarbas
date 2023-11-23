# Baigiamasis Darbas

[Ornamentai.lt](https://ornamentai.lt/)

1. Scenario. Login

   1. Test Case. Login with valid data
   
      *Precondition: Website is opened*

      1. Click on User icon
      2. Enter "email37589@gmail.com" in the email field
      3. Enter "testinePaskyra7" in the password field
      4. Click "PRISIJUNGTI"
      
      *Assert that expected Username is visible*

   2. Test Case. Login with invalid data
       
      *Precondition: Website is opened*

      1. Click on User icon
      2. Enter "email37589@gmail.com" in the email field
      3. Enter "testinePaskyra" in the password field
      4. Click "PRISIJUNGTI"
      
      *Assert that error message "Klaida: Jūsų įvestas slaptažodis el. pašto adresui email37589@gmail.com yra neteisingas. Pamiršote slaptažodį?" is displayed.*

2. Scenario. Cart

   1. Test Case. Adding items from catalogue to the cart
   
      *Precondition: Website is opened*

      1. Click "EL. PARDUOTUVĖ"
      2. Click "DAILĖ"
      3. Expand menu "PASTELĖ"
      4. Click "ALIEJINĖ PASTELĖ"
      5. Click on the item "Aliejinė pastelė ARTix Arts 12 spalvų"
      6. Increase quantity by one
      7. Click "Į KREPŠELĮ"
      
      *Assert that Cart icon with label "2" is displayed and that message "2 × “Aliejinė pastelė ARTix Arts 12 spalvų” - įdėti į krepšelį" is displayed*

   2. Test Case. Removing items from the cart
   
      *Preconditions: Website is opened. Two Gift Vouchers are added in the cart.*

      1. Click on the Cart icon
      2. Click the first "x" button
      3. Click the last "x" button
      
      *Assert* that message "Krepšelis dar tuščias." is displayed*

3. Scenario. Menu Navigation

   1. Test Case. Confirming correct contact details in the Education catalogue

      *Preconditions: Website is opened*

      1. Click MENU button
      2. Click Menu item "EDUKACIJOS"
      3. Click Menu item "EDUKACIJA – TEKSTILĖS DEKORAVIMAS"
      4. Click Arrow button to the right

      *Assert* that text "Susisiekite +370 630 20570\r\nParašykite info@ornamentai.lt" is displayed*


# BaigiamasisDarbas

[Ornamentai.lt](https://ornamentai.lt/)

1. Scenario. Login

   1. Test Case. Login with valid data
   
      *Precondition: Website is opened*

      1. Click on User icon
      2. Enter "email37589@gmail.com" in the email field
      3. Enter "testinePaskyra7" in the password field
      4. Click "Prisijungti"
      
      *Assert that Username is visible*

   2. Test Case. Login with invalid data
       
      *Precondition: Website is opened*

      1. Click on User icon
      2. Enter "email37589@gmail.com" in the email field
      3. Enter "testinePaskyra" in the password field
      4. Click "Prisijungti"
      
      *Assert that error message "Klaida: Jūsų įvestas slaptažodis el. pašto adresui email37589@gmail.com yra neteisingas. Pamiršote slaptažodį?" is displayed.*

2. Scenario. Cart

   1. Test Case. Adding an item from "MENU" to the cart
   
      *Precondition: Website is opened*

      1. Click on "MENU"
      2. Click "DAILĖ"
      3. Expand menu "MODELIAVIMAS IR MAKETAVIMAS"
      4. Click "SKULPTŪRA"
      5. Click on the first option in the catalogue
      6. Click "Į KREPŠELĮ"
      
      *Assert that Cart icon with label "1" is displayed*

   2. Test Case. Adding a gift voucher to the cart
   
      *Preconditions: Website is opened. One item is already added to the cart.*
      1. Click on "DOVANŲ KUPONAI"
      2. From dropdown menu choose "50.00€"
      3. Click "Į KREPŠELĮ"
      
      *Assert that Cart icon with label "2" is displayed*
      
   3. Test Case. Removing items from the cart
   
      *Preconditions: Website is opened. Three items are added in the cart.*

      1. Click on the Cart icon
      2. Click the first "x" button
      3. Click the second "x" button
      
      *Assert* that message "Krepšelis dar tuščias" is visible*



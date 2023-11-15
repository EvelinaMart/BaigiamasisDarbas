# BaigiamasisDarbas

[Laisvalaikio dovanos](https://www.laisvalaikiodovanos.lt/)

1. Scenario. Login
   1. Test Case. Login with valid data
   
      (Precondition: Website is opened)
      1. Mouse over "Info"
      2. Click "Prisijungti"
      3. Enter "email37589@gmail.com" in the email field
      4. Enter "testinisPastas3" in the password field
      5. Click "Prisijungti"
      6. *Assert* that Profile icon is visible

   2. Test Case. Login with invalid data
       
      (Precondition: Website is opened)
      1. Mouse over "Info"
      2. Click "Prisijungti"
      3. Enter "email37589@gmail.com" in the email field
      4. Enter "testinisPastas" in the password field
      5. Click "Prisijungti"
      6. *Assert* that error message "REGISTRACIJOS KLAIDA Slaptažodis arba el. paštas yra neteisingi." is displayed.

2. Scenario. Adding an item from menu to the cart
   1. Test Case. Adding an item to the cart by the category of the gift
   
      (Preconditions: Website is opened. User is logged in to the account)
      1. Mouse over "Dovanos"
      2. Click "Aktyvus laisvalaikis"
      3. Click "Daugiau"
      4. Click "Dovanų rinkinys „Su gimtadieniu!“"
      5. Click "Į krepšelį"
      6. *Assert* that "PREKIŲ KREPŠELIS (1)" is visible

3. Scenario. Adding a gift voucher to the cart
   1. Test Case. Adding a gift voucher to the cart
   
      (Preconditions: Website is opened. User is logged in to the account)
      1. Click on Home page icon "Laisvalaikio dovanos"
      2. Click "30 eur vertės"
      3. Click "Įdėti į krepšelį"
      4. *Assert* that "PREKIŲ KREPŠELIS (1)" is visible

3. Scenario. Removing an item/items from the cart
   1. Test Case. Remove multiple (3) items from the cart
   
      (Preconditions: Website is opened. User is logged in to the account. "PREKIŲ KREPŠELIS (3)" is visible after clicking on the Cart icon)
      1. Click on the Cart icon
      2. Click the first "x" button
      3. Click the second "x" button
      4. Click the third "x" button
      5. *Assert* that "PREKIŲ KREPŠELIS TUŠČIAS" is visible



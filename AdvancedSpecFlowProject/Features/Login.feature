Feature: Login functionality
Необходимо проверить страницу логина

    @GUI
    Scenario: Successful login
        Given open the login page
        When user enter "atrostyanko@gmail.com" to the email field
        * user enter "Qwertyu_1" to the password field
        * user clicks the log in button
        Then user is successfully logged in

    @GUI
    Scenario: Incorrect login
        Given open the login page
        When user enter "atrostyankoasd@gmail.com" to the email field
        * user enter "Qwertyu_1" to the password field
        * user clicks the log in button
        Then error "Email/Login or Password is incorrect. Please try again." is displayed

    @GUI
    Scenario: Incorrect password
        Given open the login page
        When user enter "atrostyanko@gmail.com" to the email field
        * user enter "Qwertyu_2" to the password field
        * user clicks the log in button
        Then error "Email/Login or Password is incorrect. Please try again." is displayed.
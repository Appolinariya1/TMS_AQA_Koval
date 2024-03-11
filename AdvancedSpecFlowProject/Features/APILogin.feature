Feature: ApiLogin functionality
Необходимо проверить страницу логина

    Scenario: Successful login
        Given sent request with correct data
        Then response status code is 200
Feature: Более сложный тест

Scenario: Использование AND в Given
Given открыт браузер
And страница логина открыта

Scenario: Использование * в Given
Given открыт браузер
* страница логина открыта
Then username field is displayed
But login button is disabled


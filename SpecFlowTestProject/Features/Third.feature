Feature: Тест с Background блоком

    Background: Preconditions
        Given открыт браузер
        * страница логина открыта

    Scenario: Использование AND в Given

    Scenario: Использование * в Given
        Then username field is displayed
        * username field is displayed

    Scenario: Использование But
        Then username field is displayed
        But login button is disabled
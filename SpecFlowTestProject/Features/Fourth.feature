Feature: Параметризированные тесты

    Scenario: Простая параметризация
        Given открыт браузер
        * страница логина открыта
        When user "atrostyanko@gmail.com" with password "Americana#1978" logged in
        Then the add project button is displayed
        * username is "Alex Tros"
        * a project ID is 23

    @GUI
    Scenario Outline: Таблицы
        Given открыт браузер
        * страница логина открыта
        When user "<username>" with password "<password>" logged in
        Then username is "<visibleText>"

    @table
        Examples:
          | username                | password       | visibleText |
          | atrostyanko@gmail.com   | Americana#1978 | Alex Tros   |
          | atrostyanko+1@gmail.com | Americana#1978 | Alex Tros1  |

    Scenario: Use big text
        Given a blog post named "Random" with Markdown body
        """markdown
        Some Title, Eh?
        ===============
        Here is the first paragraph of my blog post. Lorem ipsum dolor sit amet,
        consectetur adipiscing elit.
        """
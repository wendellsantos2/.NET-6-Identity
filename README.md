# .NET-6-Identity
Organização e separação de código:

Divida o código em módulos/classes com responsabilidades únicas.
Siga o princípio da Responsabilidade Única.
Modularize em camadas lógicas (UI, lógica de negócio, acesso a dados).
Use injeção de dependência para facilitar a substituição e testabilidade.
Cadastro de usuários com o Identity:

Configure o Identity na aplicação.
Utilize o UserManager para criar e salvar usuários.
Defina propriedades e senha do usuário.
Manipule o resultado retornado pelo UserManager.
Autenticação de usuários com o Identity:

Configure a autenticação na aplicação.
Use o método SignInManager.PasswordSignInAsync() para autenticar usuários.

namespace view;

public class Login : Form
{
    private readonly Label LabelEmail;
    private readonly Label LabelSenha;
    private readonly TextBox InputEmail;
    private readonly TextBox InputSenha;
    private readonly Button ButtonEntrar;

    public Login()
    {
        Size = new Size(400, 300);
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.Black;
        ForeColor = Color.White;

        LabelEmail = new Label {
            Text = "Email:",
            Location = new Point(50, 50),
            Size = new Size(50, 50)
        };
        LabelSenha = new Label {
            Text = "Senha:",
            Location = new Point(50, 100),
            Size = new Size(50, 50)
        };

        InputEmail = new TextBox {
            Location = new Point(100, 50),
            Size = new Size(200, 50)
        };
        
        InputSenha = new TextBox {
            Location = new Point(100, 100),
            Size = new Size(200, 50)
        };

        ButtonEntrar = new Button {
            Text = "ENTRAR",
            Location = new Point(150, 150),
        };
        ButtonEntrar.Click += ClickEntrar;

        Controls.Add(LabelEmail);
        Controls.Add(LabelSenha);
        Controls.Add(InputEmail);
        Controls.Add(InputSenha);
        Controls.Add(ButtonEntrar);
    }

    private void ClickEntrar(object? sender, EventArgs e){
        MessageBox.Show("Botão clicado");
    }
}

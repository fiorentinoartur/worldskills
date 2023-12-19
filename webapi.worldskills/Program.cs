using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddAuthentication(options =>
{
    options.DefaultChallengeScheme = "JwtBearer";
    options.DefaultAuthenticateScheme = "JwtBearer";
})
    .AddJwtBearer("JwtBearer", options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            //valida quem est� solicitando
            ValidateIssuer = true,

            //Validar quem est� recebendo
            ValidateAudience = true,

            //Define se o tempo de expira��o ser� validado
            ValidateLifetime = true,

            //Forma de criptografia e valida a chave de autentica��o
            IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("ranking-chave-autenticacao-webapi-dev")),

            //Valida o tempo de expira��o do token
            ClockSkew = TimeSpan.FromMinutes(5),

            //nome do issuer (de onde est� vindo)
            ValidIssuer = "webapi.ranking",

            //nome do audience (para onde est� vindo)
            ValidAudience = "webapi.raking+"
        };
    });

builder.Services.AddSwaggerGen(options =>
{
    //Adiciona informa��es sobre  API no Swagger
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API WorldSkills +",
        Description = "API para gerenciamento das WorldSkills ",
        Contact = new OpenApiContact
        {
            Name = "Senai de Inform�tica - Turma Manh�",
            Url = new Uri("https://github.com/fiorentinoartur")
        },
    });

    // Configura o Swagger para usar o arquivo XML gerado
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";


    //Usando a autentica�ao no Swagger
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Value: Bearer TokenJWT ",
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });



});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});


app.MapControllers();

app.UseAuthentication();
app.UseAuthorization();


app.UseHttpsRedirection();

app.Run();

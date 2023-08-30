using Jfk.Tc.Decn.Soap;
using Jfk.Tc.Decn.Infrastructure;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddScoped<ICreditCardSoapService, CreditCardSoapService>();
builder.Services.AddInfrastructure();
builder.Services.AddHttpClient();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<ICreditCardSoapService>("/CreditCard.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
    endpoints.UseSoapEndpoint<ICreditCardSoapService>("/Service2.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});

app.Run();

# BlazorEasyJsInterop
Easily call JS interop using Typescript d.ts from Blazor C#

Add this to your scripts
------------------------

```
var functions = {};

window["lt"]["storeProcedure"] = function (key: string, code: string) {
    var fun = new Function("p", code);
    functions[key] = fun;
}

window["lt"]["execute"] = function (code: string, parameters: object[], key:string) {
    var fun = new Function("p", code);
    if (key !== null) {
        functions[key] = fun;
    }
    var returns = fun.call(this, parameters);
    return returns;
}

window["lt"]["executeStored"] = function (key: string, parameters: object[]) {
    var fun = functions[key];
    var returns = fun.call(this, parameters);
    return returns;
}
```

Create an executor
------------------
```
public class Executor : IScriptExecutor
{
    IJSRuntime Javascript;
    public Executor(IJSRuntime javascript){
        JavaScript = javascript;
    }
    public Task<T> ExecuteAsync<T>(string javascript, params object[] parameters)
    {
      JavaScript.InvokeAsync<T>(javaScript, parameters)
    }
}
```
Generate code
-------------
```
var generator = new Generator(new ConsoleExecutor(), new GeneratorOptions()
{
    DisableParameterBag = true
});
Leaflet.Map map = null;
var scope = await generator.StoredProcedure(async scope =>
{
    var L = await scope.GetDefinition<Leaflet>();
    map = L.map("map", scope.Instantiate<Leaflet.MapOptions>((scope, op) =>
    {
        op.dragging = true;
        op.tap = false;
        op.center = new Union<Leaflet.LatLng, Leaflet.LatLngLiteral, Leaflet.LatLngTuple>(scope.Instantiate<Leaflet.LatLngLiteral>((scope, ll) =>
        {
            ll.lat = 51.5;
            ll.lng = -0.09;
        }, "centerOptions", true));
    }, "mapOptions", true))
    .setView(new Union<Leaflet.LatLng, Leaflet.LatLngLiteral, Leaflet.LatLngTuple>(scope.Instantiate<Leaflet.LatLngLiteral>((scope, ll) =>
    {
        ll.lat = 51.5;
        ll.lng = -0.09;
    }, null, true)), 13, null);
    var tile = L.tileLayer("https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png", scope.Instantiate<Leaflet.TileLayerOptions>((scope, op) => {
        op.attribution = "&copy; <a href=\"https://www.openstreetmap.org/copyright\">OpenStreetMap</a> contributors";
    }, "options", true)).addTo(map);
    for (int i = 0; i < 10; i++)
    {
        L.marker(new Union<Leaflet.LatLng, Leaflet.LatLngLiteral, Leaflet.LatLngTuple>(scope.Instantiate<Leaflet.LatLngLiteral>((scope, ll) =>
        {
            ll.lat = 51.5+i*0.2;
            ll.lng = -0.09+i*0.2;
        }, null, true)), null)
        .addTo(map)
        .bindPopup(new Union<Func<Leaflet.Layer, Leaflet.Content>, Leaflet.Content, Leaflet.Popup>(new Leaflet.Content("A pretty CSS3 popup.<br> Easily customizable.")), null)
        .openPopup(null);
    }
});
 ```
 Execute the code
 -------------------
 ```
_ = scope.Execute<object>(null, true);
 ```

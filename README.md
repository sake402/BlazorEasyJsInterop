# BlazorEasyJsInterop
Easily call JS interop using Typescript d.ts from Blazor C#

Add this to your scripts
------------------------

```JavaScript
var scopes = {};
var gens = {};

window["lt"]["storeProcedure"] = function (gkey, skey, code, parameters) {
    var scope = { f: new Function("p", "x", code), p:parameters }
    scopes[skey] = scope;
    gens[gkey] = { x: {} };
}

window["lt"]["execute"] = function (code, parameters, gkey, skey) {
    var fun = new Function("p", "x", code);
    var gen;
    if (skey !== null) {
        gen = gens[gkey] = { x: {} };
        scopes[skey] = { f: fun };
    }
    var returns = fun.call(fun, parameters, gen.x);
    return returns;
}

window["lt"]["executeStored"] = function (gkey, skey, parameters) {
    var scope = scopes[skey];
    var gen = gens[gkey];
    var p = { ...scope.p, ...parameters };
    var returns = scope.f.call(scope.f, p, gen.x);
    return returns;
}

window["lt"]["createClass"] = function (gkey, skey, parameters) {
    var scope = scopes[skey];
    var gen = gens[gkey];
    var p = { ...scope.p, ...parameters };
    var mclass = scope.f.call(scope.f, p, gen.x);
    scope.class = mclass;
}

window["lt"]["callMember"] = function (gkey, skey, member, parameters) {
    var scope = scopes[skey];
    var gen = gens[gkey];
    var p = { ...scope.p, ...parameters };
    var method = scope.class[member];
    var returns = method.call(scope.class, p, gen.x);
    returns;
}
```

Create an executor
------------------
```C#
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
```C#
var generator = new Generator(new Executor(), new GeneratorOptions()
{
});
Leaflet.Map map = null;
var scope = await generator.Function<object>(async scope =>
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
 ```C#
_ = scope.Execute<object>(null, true);
 ```

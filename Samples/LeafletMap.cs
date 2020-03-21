using LivingThing.TCCS.Core;
using LivingThing.TCCS.Definitions;
using LivingThing.TCCS.Definitions.Javascript;
using LivingThing.TCCS.Definitions.Util;
using LivingThing.TCCS.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LivingThing.TCCS.Samples
{    
    public static class LeafletMap
    {
        public async static void Run()
        {
            var generator = new Generator(new ConsoleExecutor(), new GeneratorOptions()
            {
                DisableParameterBag = true
            });
            Leaflet.Map map = null;
            var scope = await generator.StoredProcedure(async scope =>
            {
                Union<int, double, string> cc = "";
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
                }, "mapOptions", true));
                var map2 = map.setView(new Union<Leaflet.LatLng, Leaflet.LatLngLiteral, Leaflet.LatLngTuple>(scope.Instantiate<Leaflet.LatLngLiteral>((scope, ll) =>
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
            _ = scope.Execute<object>(null, true);
            //scope.ParameterBag.Set(map, "map2");
            _ = scope.Execute<object>();
            System.Console.ReadLine();
        }
    }
}

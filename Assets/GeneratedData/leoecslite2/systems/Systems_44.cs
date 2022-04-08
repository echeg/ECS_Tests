using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System44 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component37>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component13>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component13>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component427>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component427>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component378>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component378>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component459>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component459>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System23 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component225>().Inc<Component94>().Inc<Component161>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component70>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component70>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component262>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component262>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component183>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component183>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component323>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component323>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

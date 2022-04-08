using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System33 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component195>().Inc<Component118>().Inc<Component364>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component95>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component95>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component103>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component103>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component7>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component7>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component200>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component200>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

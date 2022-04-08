using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System11 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component203>().Inc<Component180>().Inc<Component320>().Inc<Component113>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component359>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component359>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component120>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component120>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component277>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component277>().Get(entity);
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
  }
 }
}

}

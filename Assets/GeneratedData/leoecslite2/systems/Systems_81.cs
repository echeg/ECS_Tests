using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System81 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component346>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component166>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component166>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component364>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component364>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component208>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component208>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component480>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component480>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

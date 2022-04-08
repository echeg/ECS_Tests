using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System58 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component212>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component66>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component66>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component35>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component35>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component314>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component314>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component206>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component206>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

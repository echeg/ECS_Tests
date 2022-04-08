using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System47 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component233>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component316>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component316>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component357>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component357>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component422>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component422>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component408>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component408>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

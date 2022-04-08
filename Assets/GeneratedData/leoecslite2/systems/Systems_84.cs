using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System84 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component372>().Inc<Component307>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component39>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component39>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component487>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component487>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component355>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component355>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component95>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component95>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

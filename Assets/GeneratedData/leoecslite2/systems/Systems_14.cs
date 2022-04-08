using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System14 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component416>().Inc<Component204>().Inc<Component90>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component203>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component203>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component444>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component444>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component5>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component5>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component166>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component166>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System78 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component166>().Inc<Component354>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component109>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component109>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component296>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component296>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component418>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component418>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component41>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component41>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

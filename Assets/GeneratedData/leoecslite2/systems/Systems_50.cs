using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System50 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component422>().Inc<Component444>().Inc<Component361>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component11>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component11>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component46>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component46>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component340>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component340>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component398>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component398>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

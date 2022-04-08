using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System20 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component94>().Inc<Component261>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component456>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component456>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component373>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component373>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component248>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component248>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component129>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component129>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

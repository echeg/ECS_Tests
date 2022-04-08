using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System24 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component335>().Inc<Component265>().Inc<Component256>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component464>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component464>().Get(entity);
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
   if (_world.GetPool<Component55>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component55>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component371>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component371>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System91 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component361>().Inc<Component192>().Inc<Component133>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component248>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component248>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component235>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component235>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component494>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component494>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component266>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component266>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

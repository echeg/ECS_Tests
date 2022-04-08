using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System53 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component469>().Inc<Component138>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component453>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component453>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component183>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component183>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component368>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component368>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component21>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component21>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System62 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component65>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component105>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component105>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component149>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component149>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component486>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component486>().Get(entity);
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
  }
 }
}

}

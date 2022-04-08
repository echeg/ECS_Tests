using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System87 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component119>().Inc<Component101>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component126>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component126>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component346>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component346>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component104>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component104>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component90>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component90>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

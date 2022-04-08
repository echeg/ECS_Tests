using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System66 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component15>().Inc<Component418>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component143>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component143>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component283>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component283>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component31>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component31>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component499>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component499>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

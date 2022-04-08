using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System71 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component27>().Inc<Component408>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component379>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component379>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component118>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component118>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component178>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component178>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component299>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component299>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

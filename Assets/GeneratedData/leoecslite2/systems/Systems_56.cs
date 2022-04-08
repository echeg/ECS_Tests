using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System56 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component370>().Inc<Component204>().Inc<Component241>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component26>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component26>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component163>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component163>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component282>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component282>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component408>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component408>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

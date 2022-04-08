using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System3 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component419>().Inc<Component396>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component197>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component197>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component125>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component125>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component196>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component196>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component407>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component407>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

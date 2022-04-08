using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System55 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component434>().Inc<Component477>().Inc<Component46>().Inc<Component360>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component115>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component115>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component109>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component109>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component293>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component293>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component481>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component481>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

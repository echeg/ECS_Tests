using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System80 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component143>().Inc<Component324>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component482>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component482>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component447>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component447>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component161>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component161>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component294>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component294>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

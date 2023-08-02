using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System12 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component179>().Inc<Component454>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component172>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component172>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component79>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component79>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component80>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component80>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component424>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component424>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}